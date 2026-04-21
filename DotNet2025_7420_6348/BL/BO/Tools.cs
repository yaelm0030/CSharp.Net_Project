using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    internal static class Tools
    {
        public static string ToStringProperty<T>(this T obj)
        {
            string str = "";

            foreach(PropertyInfo item in obj.GetType().GetProperties())
            {
                if(item.PropertyType.IsPrimitive
                    || item.PropertyType==typeof(DateTime)
                    || item.PropertyType==typeof(string))
                {
                    str+= item.Name+": "+item.GetValue(obj)+",";
                }
                else
                {
                    str += item.Name + ": ";
                    str += item.GetValue(obj).ToStringProperty();
                }
            }

            return str;
        }

        public static DO.Customer ConvertBOCustomerToDOCustomer<T>(this T customer) where T:BO.Customer{
            return new DO.Customer(customer.Id, customer.Name,customer.Address,customer.PhoneNumber);
        }
        public static BO.Customer ConvertDOCustomerToBOCustomer<T>(this T customer) where T : DO.Customer
        {
            return new BO.Customer(customer.Id, customer.Name, customer.Address, customer.PhoneNumber);
        }
        public static DO.Product ConvertBOProductToDOProduct<T>(this T product) where T : BO.Product
        {
            return new DO.Product(product.Id,product.Name,(DO.Category)(int)product.Category,product.Price,product.InStock);
        }
        public static BO.Product ConvertDOProductToBOProduct<T>(this T product) where T : DO.Product
        {
            return new BO.Product(product.Id, product.Name, (BO.Category)(int)product.Category, product.Price, product.InStock);
        }
        public static DO.Sale ConvertBOSaleToDOSale<T>(this T sale) where T : BO.Sale
        {
            return new DO.Sale(sale.Id,sale.ProductId,sale.AmountNeeded,sale.PriceAfterDiscount,sale.ClubCustomerSale,sale.SaleBeginningDate,sale.SaleEndingDate);
        }
        public static BO.Sale ConvertDOSaleToBOSale<T>(this T sale) where T : DO.Sale
        {
            return new BO.Sale(sale.Id, sale.ProductId, sale.AmountNeeded, sale.PriceAfterDiscount, sale.ClubCustomersSale, sale.SaleBeginningDate, sale.SaleEndingDate);
        }
    }
}
