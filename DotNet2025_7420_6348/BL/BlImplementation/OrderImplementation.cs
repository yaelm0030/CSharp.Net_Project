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
              
                if(product.InStock>=amount)
                {
                    product.InStock-=amount;
                    /////????
                    _dal.Product.Update(product.ConvertBOProductToDOProduct());
                    ProductInOrder prodInOrder = (from prod in order.Products
                               where prod.Id == productId
                               select prod).FirstOrDefault();
                    if (prodInOrder != null)
                    {
                        prodInOrder.Amount += amount;
                    }
                    else
                    {
                        prodInOrder = new ProductInOrder(productId, product.Name, product.Price, amount, new List<SaleOfProduct>(), 0);
                        order.Products.Add(prodInOrder);
                    }
                    SearchSaleForProduct(prodInOrder, order.ClubCustomer);
                    CalcTotalPriceForProduct(prodInOrder);
                    CalcTotalPrice(order);
                    List<SaleOfProduct>sales=new List<SaleOfProduct>();
                    return (from prod in order.Products
                           from sale in prod.Sales
                           select sale).ToList();
                }
                else
                {
                    throw new NoProductsInStock("There are no product in stock right now");
                }
            }
            return new List<SaleOfProduct>();
        }

        public void CalcTotalPrice(Order order)
        {
            foreach(ProductInOrder product in order.Products)
            {
                CalcTotalPriceForProduct(product);
                order.FinalPrice += product.FinalPrice;
            }
        }

        public void CalcTotalPriceForProduct(ProductInOrder product)
        {
            int count = product.Amount;
            List<SaleOfProduct> sales=new List<SaleOfProduct>();
            foreach(SaleOfProduct sale in product.Sales)
            {
                if (count == 0)
                    break;
                if (count >= sale.Amount)
                {
                    product.FinalPrice += count / sale.Amount * sale.Price;
                    count %= sale.Amount;
                    sales.Add(sale);
                }
            }
            product.FinalPrice += count * product.Price;
            product.Sales= sales;
        }

        public void DoOrder(Order order)
        {
            //////////////////////
            throw new NotImplementedException();
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
