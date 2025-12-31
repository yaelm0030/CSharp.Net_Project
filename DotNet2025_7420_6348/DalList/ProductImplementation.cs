using DO;
using DalApi;

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
            throw new ProductIdNotFoundException(id);

    }

    public Product? Read(int id)
    {
        if (DataSource.Products.Exists(prod => prod != null && prod.Id == id))
            return DataSource.Products.Find(prod => prod!.Id == id);
        else
            throw new ProductIdNotFoundException(id);
    }

    public List<Product> ReadAll()
    {
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
            throw new ProductIdNotFoundException(p.Id);

    }
}

