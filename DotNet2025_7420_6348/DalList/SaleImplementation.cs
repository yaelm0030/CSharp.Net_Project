using DO;
using DalApi;

namespace Dal;

public class SaleImplementation : ISale
{
    public int Create(Sale s)
    {
        if (!DataSource.Sales.Exists(sale => sale != null && sale.Id == s.Id))
        {
            int myId = DataSource.Config.GetSalesCounter;
            s=s with { Id = myId };
            DataSource.Sales.Add(s);
            return s.Id;
        }
        else
                throw new SaleAlreadyExistsException("Sale Already Exists");
    }

    public void Delete(int id)
    {
        if (DataSource.Sales.Exists(sale => sale != null && sale.Id == id))
            DataSource.Sales.Remove(DataSource.Sales.Find(sale => sale!.Id == id));
        else
            throw new SaleIdNotFoundException(id);
    }

    public Sale? Read(int id)
    {
        if (DataSource.Sales.Exists(sale => sale != null && sale.Id == id))
            return DataSource.Sales.Find(sale => sale!.Id == id);
        else
            throw new SaleIdNotFoundException(id);
    }

    public List<Sale> ReadAll()
    {
        return new List<Sale?>(DataSource.Sales!=null?DataSource.Sales:new List<Sale?>())!;
    }

    public void Update(Sale s)
    {
        if (DataSource.Sales.Exists(sale => sale != null && sale.Id == s.Id))
            DataSource.Sales[DataSource.Sales.FindIndex(sale => sale!.Id == s.Id)] = s;
        else
            throw new SaleIdNotFoundException(s.Id);
    }
}
