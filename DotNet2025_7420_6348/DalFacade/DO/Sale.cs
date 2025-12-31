using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Sale(
            int Id =0,
            int ProductId = 0,
            int AmountNeeded = 0,
            double PriceAfterDiscount = 0,
            bool ClubCustomersSale = false
        )
    {
        DateTime SaleBeginningDate = DateTime.Now;
        DateTime SaleEndingDate = DateTime.Now.AddMonths(1);

        public Sale():this(0,0,0,0,false)
        {
            SaleBeginningDate = DateTime.Now;
            SaleEndingDate = DateTime.Now.AddMonths(1);
        }

        public Sale(int ProductId, int AmountNeeded, double PriceAfterDiscount, bool ClubCustomersSale, DateTime SaleBeginningDate, DateTime SaleEndingDate):this(0, ProductId, AmountNeeded, PriceAfterDiscount, ClubCustomersSale)
        {
            this.SaleBeginningDate = SaleBeginningDate;
            this.SaleEndingDate = SaleEndingDate;
        }
    }
}
