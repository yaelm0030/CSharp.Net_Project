using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Sale
    {
        public int Id { get; }
        public int ProductId { get; set; }
        public int AmountNeeded { get; set; }
        public double PriceAfterDiscount { get; set; }
        public bool ClubCustomerSale { get; set; }
        public DateTime SaleBeginningDate { get; set; }
        public DateTime SaleEndingDate { get; set; }

        public Sale(int id, int productId, int amountNeeded, double priceAfterDiscount, bool clubCustomerSale, DateTime saleBeginningDate, DateTime saleEndingDate)
        {
            Id = id;
            ProductId = productId;
            AmountNeeded = amountNeeded;
            PriceAfterDiscount = priceAfterDiscount;
            ClubCustomerSale = clubCustomerSale;
            SaleBeginningDate = saleBeginningDate;
            SaleEndingDate = saleEndingDate;

        }
        public Sale()
        {
            Id = 00;
            ProductId = 00;
            AmountNeeded = 0;
            PriceAfterDiscount = 0;
            ClubCustomerSale = false;
            SaleBeginningDate = DateTime.Now;
            SaleEndingDate = DateTime.Now;

        }
        public override string ToString()
        {
            return "Id= "+Id+ ", ProductId= " + ProductId + ", AmountNeeded= " + AmountNeeded + ", PriceAfterDiscount= " + PriceAfterDiscount + ", ClubCustomerSale= " + ClubCustomerSale + ", SaleBeginningDate= " + SaleBeginningDate + ", SaleEndingDate= " + SaleEndingDate;
        }
    }
}
