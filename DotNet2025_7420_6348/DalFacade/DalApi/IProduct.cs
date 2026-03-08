using DO;

namespace DalApi;

public interface IProduct:ICrud<Product> { 
    int Create(Product p);
    Product? Read(int id);
    Product? Read(Func<Product, bool> filter);
    List<Product?> ReadAll(Func<Product,bool>?filter=null);
    void Update(Product p);
    void Delete(int id);
}
