using DO;
using DalApi;

namespace Dal;

internal class ProductImplementation : IProduct
{
    public int Create(Product p)
    {
        if (!DataSource.Products.Exists(prod => prod.Id == p.Id))
            DataSource.Products.Add(p);
        else
            throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        if (DataSource.Products.Exists(prod=>prod.Id==id))
            DataSource.Products.Remove(DataSource.Products.Find(prod=>prod.Id==id));
        else
            throw new NotImplementedException();
    }

    public Product? Read(int id)
    {
        if (DataSource.Products.Exists(prod => prod.Id == id))
            return DataSource.Products.Find(prod=>prod.Id==id);
        else
            throw new NotImplementedException();
    }

    public List<Product> ReadAll()
    {
        return DataSource.Products;
        throw new NotImplementedException();
    }

    public void Update(Product p)
    {
        if (DataSource.Products.Exists(prod => prod.Id == p.Id))
            DataSource.Products[DataSource.Products.FindIndex(prod => prod.Id == p.Id)] = p;
        else
            throw new NotImplementedException();
    }
}

