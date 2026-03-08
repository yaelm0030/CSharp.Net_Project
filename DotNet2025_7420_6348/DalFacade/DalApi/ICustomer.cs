using DO;

namespace DalApi;

public interface ICustomer:ICrud<Customer>
{
    int Create(Customer c);
    Customer? Read(int id);
    Customer? Read(Func<Customer, bool> filter);
    List<Customer?> ReadAll(Func<Customer, bool>?filter=null);
    void Update(Customer c);
    void Delete(int id);
}
