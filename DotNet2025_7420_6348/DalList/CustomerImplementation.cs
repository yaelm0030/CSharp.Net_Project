using DO;
using DalApi;

namespace Dal;

internal class CustomerImplementation : ICustomer
{
    public int Create(Customer c)
    {
        if (!DataSource.Customers.Exists(cus => cus.Id == c.Id))
        {
            DataSource.Customers.Add(c);
            return c.Id;
        }
        else
            throw new DalAlreadyExists($"Customer with id: {c.Id} already exists");
    }

    public void Delete(int id)
    {
        if (DataSource.Customers.Exists(cus => cus != null && cus.Id == id))
            DataSource.Customers.Remove(DataSource.Customers.Find(cus => cus!.Id == id));
        else
            throw new DalIDNotFoundException($"Customer with id: {id} was not found");
    }

    public Customer? Read(int id)
    {

        if (DataSource.Customers.Exists(cus => cus != null && cus.Id == id))
            return DataSource.Customers.Find(cus => cus!.Id == id);
        else
            throw new DalIDNotFoundException($"Customer with id: {id} was not found");
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        return DataSource.Customers.FirstOrDefault(filter!);
    }

    public List<Customer?>ReadAll(Func<Customer, bool>?filter=null)
    {
        if(filter!=null)
            return DataSource.Customers!.Where<Customer>(filter).ToList()!;
        return new List<Customer?>(DataSource.Customers != null ? DataSource.Customers : new List<Customer?>())!;
    }

    public void Update(Customer c)
    {
        if (DataSource.Customers.Exists(cus => cus != null && cus.Id == c.Id))
        {
            Delete(c.Id);
            DataSource.Customers.Add(c);
        }
        else
            throw new DalIDNotFoundException($"Customer with id: {c.Id} was not found");
    }
}
