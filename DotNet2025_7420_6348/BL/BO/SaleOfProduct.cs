using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class SaleOfProduct
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public bool ClubCustomerSale { get; set; }

        public SaleOfProduct(int id, int amount, double price, bool clubCustomerSale)
        {
            Id = id;
            Amount = amount;
            Price = price;
            ClubCustomerSale = clubCustomerSale;
        }
    }
}
