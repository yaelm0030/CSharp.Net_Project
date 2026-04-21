using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Order
    {
        public bool ClubCustomer { get; set; }
        public List<ProductInOrder>? Products { get; set; }
        public double FinalPrice { get; set; }

        public Order(bool clubCustomer, List<ProductInOrder>? products, double finalPrice)
        {
            ClubCustomer = clubCustomer;
            Products = products;
            FinalPrice = finalPrice;
        }
    }
}
