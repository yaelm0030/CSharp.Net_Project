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
            throw new CustomerAlreadyExistsException($"Customer With id: {c.Id} Already Exists");
    }

    public void Delete(int id)
    {
        if (DataSource.Customers.Exists(cus => cus != null && cus.Id == id))
            DataSource.Customers.Remove(DataSource.Customers.Find(cus => cus!.Id == id));
        else
            throw new CustomerIdNotFoundException(id);
    }

    public Customer? Read(int id)
    {

        if (DataSource.Customers.Exists(cus => cus != null && cus.Id == id))
            return DataSource.Customers.Find(cus => cus!.Id == id);
        else
            throw new CustomerIdNotFoundException(id);
    }

    public List<Customer> ReadAll()
    {
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
            throw new CustomerIdNotFoundException(c.Id);
    }
}
