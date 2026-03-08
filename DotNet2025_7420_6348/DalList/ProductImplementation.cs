using DO;
using DalApi;
using System.Linq;

namespace Dal;

internal class ProductImplementation : IProduct
{
    public int Create(Product p)
    {

        int myId = DataSource.Config.GetProductCounter;
        p = p with { Id = myId };
        DataSource.Products.Add(p);
        return p.Id;
    }

    public void Delete(int id)
    {
        if (DataSource.Products.Exists(prod => prod != null && prod.Id == id))
            DataSource.Products.Remove(DataSource.Products.Find(prod => prod!.Id == id));
        else
            throw new DalIDNotFoundException($"Product with id: {id} was not found");

    }

    public Product? Read(int id)
    {
        if (DataSource.Products.Exists(prod => prod != null && prod.Id == id))
            return DataSource.Products.Find(prod => prod!.Id == id);
        else
            throw new DalIDNotFoundException($"Product with id: {id} was not found");
    }

    public Product? Read(Func<Product, bool> filter)
    {
        return DataSource.Products.FirstOrDefault(filter!);
    }

    public List<Product?> ReadAll(Func<Product,bool>?filter=null)
    {
        if (filter != null)
            return DataSource.Products.Where<Product>(filter).ToList()!;
        return new List<Product?>(DataSource.Products != null ? DataSource.Products : new List<Product?>())!;
    }

    public void Update(Product p)
    {
        if (DataSource.Products.Exists(prod => prod != null && prod.Id == p.Id))
        {
            Delete(p.Id);
            DataSource.Products.Add(p);
        }
        else
            throw new DalIDNotFoundException($"Product with id: {p.Id} was not found");

    }
}

