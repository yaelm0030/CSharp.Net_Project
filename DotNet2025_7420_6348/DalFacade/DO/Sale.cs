using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    internal class Sale
    {
        static int Counter=0;

        int Id;
        int ProductId;
        int AmountNeeded;
        double PriceAfterDiscount;
        bool ClubCustomersSale;
        DateTime SaleBeginningDate;
        DateTime SaleEndingDate;

        public Sale()
        {
            this.Id= Counter++;
            this.ProductId= 0;
            this.AmountNeeded= 0;
            this.PriceAfterDiscount= 0;
            this.ClubCustomersSale= false;
            this.SaleBeginningDate = DateTime.Now;
            this.SaleEndingDate = DateTime.Now.AddMonths(1);
        }
        public Sale(
        int ProductId,
        int AmountNeeded,
        double PriceAfterDiscount,
        bool ClubCustomersSale,
        DateTime SaleBeginningDate,
        DateTime SaleEndingDate)
        {
            this.Id =Counter++;
            this.ProductId = ProductId;
            this.AmountNeeded = AmountNeeded;
            this.ClubCustomersSale = ClubCustomersSale;
            this.SaleBeginningDate=SaleBeginningDate;
            this.SaleEndingDate= SaleEndingDate;
        }
    }
}
