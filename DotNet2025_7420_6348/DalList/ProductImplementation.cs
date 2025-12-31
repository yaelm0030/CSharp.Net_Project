using DO;
using DalApi;

namespace Dal;

public class ProductImplementation : IProduct
{
    public int Create(Product p)
    {

            if (!DataSource.Products.Exists(prod => prod != null && prod.Id == p.Id))
            {
                int myId = DataSource.Config.GetProductCounter;
                p=p with { Id = myId };
                DataSource.Products.Add(p);
                return p.Id;
            }
            else
                throw new ProductAlreadyExistsException("Product Exists Already");
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
                DataSource.Products[DataSource.Products.FindIndex(prod => prod!.Id == p.Id)] = p;
            else
                throw new ProductIdNotFoundException(p.Id);

    }
}

