using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Product
    {
        public int Id{ get; }
        public string Name{ get; set; }
        public Category Category { get; set; }
        public double Price { get; set; }
        public int InStock { get; set; }

        public Product(int id, string name, Category category, double price, int inStock)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
            InStock = inStock;
        }

        public override string ToString()
        {
            return $"Id= {Id}, Name= {Name}, Category={Category}, Price={Price}, InStock= {InStock}";
        }
    }
}
