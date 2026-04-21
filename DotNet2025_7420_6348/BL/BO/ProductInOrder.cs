using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class ProductInOrder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public List<SaleOfProduct>? Sales { get; set; }
        public double FinalPrice { get; set; }

        public ProductInOrder(int id, string name, double price, int amount, List<SaleOfProduct>? sales, double finalPrice)
        {
            Id = id;
            Name = name;
            Price = price;
            Amount = amount;
            Sales = sales;
            FinalPrice = finalPrice;
        }
    }
}
