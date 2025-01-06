using BlApi;
using BO;
using DalApi;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class OrderImplementation : BlApi.IOrder
    {
        private IDal _dal = DalApi.Factory.Get;
        public List<SaleOfProduct> AddProductToOrder(Order order, int productId, int amount)
        {
            Product? product= _dal.Product.Read(productId).ConvertDOProductToBOProduct();
            if (product != null)
            {
                ProductInOrder prodInOrder = (from prod in order.Products
                                              where prod.Id == productId
                                              select prod).FirstOrDefault();

                if (prodInOrder != null)
                {
                    if (product.InStock >= amount + prodInOrder.Amount)
                        prodInOrder.Amount += amount;
                    else
                        throw new NoProductsInStock($"There isn't enough {product.Name}s in stock right now");
                }
                else
                {
                    if (product.InStock >= amount)
                    {
                        prodInOrder = new ProductInOrder(productId, product.Name, product.Price, amount, new List<SaleOfProduct>(), 0);
                        order.Products.Add(prodInOrder);
                    }
                    else
                        throw new NoProductsInStock($"There isn't enough {product.Name}s in stock right now");

                }
                SearchSaleForProduct(prodInOrder, order.ClubCustomer);
                CalcTotalPriceForProduct(prodInOrder);
                CalcTotalPrice(order);
                List<SaleOfProduct> sales = new List<SaleOfProduct>();
                return (from prod in order.Products
                        from sale in prod.Sales
                        select sale).ToList();


                //if (product.InStock>=amount)
                //{
                //    product.InStock-=amount;
                //    /////????
                //    //_dal.Product.Update(product.ConvertBOProductToDOProduct());
                //    ProductInOrder prodInOrder = (from prod in order.Products
                //               where prod.Id == productId
                //               select prod).FirstOrDefault();
                //    if (prodInOrder != null)
                //    {
                //        prodInOrder.Amount += amount;
                //    }
                //    else
                //    {
                //        prodInOrder = new ProductInOrder(productId, product.Name, product.Price, amount, new List<SaleOfProduct>(), 0);
                //        order.Products.Add(prodInOrder);
                //    }
                //    SearchSaleForProduct(prodInOrder, order.ClubCustomer);
                //    CalcTotalPriceForProduct(prodInOrder);
                //    CalcTotalPrice(order);
                //    List<SaleOfProduct>sales=new List<SaleOfProduct>();
                //    return (from prod in order.Products
                //           from sale in prod.Sales
                //           select sale).ToList();
                //}
                //else
                //{
                //    throw new NoProductsInStock($"There isn't enough {product.Name}s in stock right now");
                //}
            }
            else
            {
                throw new Exception($"Product with id {productId} doesn't exist");
            }
        }

        public void CalcTotalPrice(Order order)
        {
            foreach(ProductInOrder product in order.Products)
            {
                CalcTotalPriceForProduct(product);
                order.FinalPrice += product.FinalPrice;
            }
        }

        //public void CalcTotalPriceForProduct(ProductInOrder product)
        //{
        //    int count = product.Amount;
        //    List<SaleOfProduct> sales=new List<SaleOfProduct>();
        //    foreach(SaleOfProduct sale in product.Sales)
        //    {
        //        if (count == 0)
        //            break;
        //        if (count >= sale.Amount)
        //        {
        //            product.FinalPrice += count / sale.Amount * sale.Price;
        //            count %= sale.Amount;
        //            sales.Add(sale);
        //        }
        //    }
        //    product.FinalPrice += count * product.Price;
        //    product.Sales= sales;
        //}

        public void CalcTotalPriceForProduct(ProductInOrder product)
        {
            product.FinalPrice = 0;

            int count = product.Amount;
            List<SaleOfProduct> appliedSales = new List<SaleOfProduct>();

            var sortedSales = product.Sales
                .Where(s => s.Amount > 0)
                .OrderByDescending(s => s.Amount);

            foreach (SaleOfProduct sale in sortedSales)
            {
                if (count == 0)
                    break;

                if (count >= sale.Amount)
                {
                    int numberOfTimesSaleApplies = count / sale.Amount;

                    product.FinalPrice += numberOfTimesSaleApplies * sale.Price;
                    count %= sale.Amount;

                    appliedSales.Add(sale);
                }
            }

            product.FinalPrice += count * product.Price;
            product.Sales = appliedSales;
        }

        public void DoOrder(Order order)
        {
            foreach(ProductInOrder productInOrder in order.Products){

                Product product= _dal.Product.Read(productInOrder.Id).ConvertDOProductToBOProduct();
                product.InStock-=productInOrder.Amount;
                _dal.Product.Update(product.ConvertBOProductToDOProduct());
            }
        }

        public void SearchSaleForProduct(ProductInOrder product, bool clubCustomer)
        {
            try
            {
                product.Sales=(from sale in _dal.Sale.ReadAll()
                               orderby sale.PriceAfterDiscount/sale.AmountNeeded
                              where sale.ProductId==product.Id&&sale.SaleBeginningDate<=DateTime.Now&&sale.SaleEndingDate>=DateTime.Now&&product.Amount>=sale.AmountNeeded&&(clubCustomer||!sale.ClubCustomersSale)
                              select new SaleOfProduct(sale.Id,sale.AmountNeeded,sale.PriceAfterDiscount,sale.ClubCustomersSale)).ToList();
            }
            catch(Exception e)
            {

            }
        }
    }
}
