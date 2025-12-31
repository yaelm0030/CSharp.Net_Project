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
            int Id,
            int ProductId,
            int AmountNeeded,
            double PriceAfterDiscount,
            bool ClubCustomersSale,
            DateTime SaleBeginningDate,
            DateTime SaleEndingDate
        )
    {

        public Sale():this(0,0,0,0,false, DateTime.Now, DateTime.Now.AddMonths(1))
        {
        }

    }
}
