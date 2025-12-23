using DO;
using DalApi;

namespace Dal;

internal class CustomerImplementation : ICustomer
{
    public int Create(Customer c)
    {
        if(!DataSource.Customers.Exists(cus=>cus.Id==c.Id))
            DataSource.Customers.Add(c);
        else
            throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        if (DataSource.Customers.Exists(cus => cus.Id == id))
            DataSource.Customers.Remove(DataSource.Customers.Find(cus=>cus.Id==id));
        else
            throw new NotImplementedException();
    }

    public Customer? Read(int id)
    {
        if (DataSource.Customers.Exists(cus => cus.Id == id))
            return DataSource.Customers.Find(cus => cus.Id == id);
        else
            throw new NotImplementedException();
    }

    public List<Customer> ReadAll()
    {
        return DataSource.Customers;
        throw new NotImplementedException();
    }

    public void Update(Customer c)
    {
        if (DataSource.Customers.Exists(cus => cus.Id == c.Id))
            //לבדוק אם תקין
            DataSource.Customers.Find(cus => cus.Id == c.Id) = c;
        else
            throw new NotImplementedException();
    }
}
