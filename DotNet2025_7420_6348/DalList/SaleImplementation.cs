using DO;
using DalApi;

namespace Dal;

internal class SaleImplementation : ISale
{
    public int Create(Sale s)
    {
        if(!DataSource.Sales.Exists(sale=>sale.Id==s.Id))
            DataSource.Sales.Add(s);
        else
            throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        if(DataSource.Sales.Exists(sale=>sale.Value==id))
            DataSource.Sales.Remove(DataSource.Sales.Find(sale=>sale.Id==id));
        else
            throw new NotImplementedException();
    }

    public Sale? Read(int id)
    {
        if (DataSource.Sales.Exists(sale => sale.Id == id))
            return DataSource.Sales.Find(sale=>sale.Id==id);
        else
            throw new NotImplementedException();
    }

    public List<Sale> ReadAll()
    {
        return DataSource.Sales;
        throw new NotImplementedException();
    }

    public void Update(Sale s)
    {
        if (DataSource.Sales.Exists(s))
            DataSource.Sales.Find(sale => sale.Id == s.Id) = s;
        else
            throw new NotImplementedException();
    }
}
