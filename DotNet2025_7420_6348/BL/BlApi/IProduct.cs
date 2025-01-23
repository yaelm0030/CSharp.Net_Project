using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BO;

namespace BlApi
{
    public interface IProduct:ICrud<Product>
    {
        int Create(Product p);
        Product? Read(int id);
        Product? Read(Func<Product, bool> filter);
        List<Product?> ReadAll(Func<Product, bool>? filter = null);
        void Update(Product p);
        void Delete(int id);
        List<Sale> GetSales(ProductInOrder p);
    }
}
