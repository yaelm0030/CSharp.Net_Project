using DO;
using DalApi;
using System.Linq;

namespace Dal;

internal class SaleImplementation : ISale
{
    public int Create(Sale s)
    {
        int myId = DataSource.Config.GetSalesCounter;
        s=s with { Id = myId };
        DataSource.Sales.Add(s);
        return s.Id;
    }

    public void Delete(int id)
    {
        if (DataSource.Sales.Exists(sale => sale != null && sale.Id == id))
            DataSource.Sales.Remove(DataSource.Sales.Find(sale => sale!.Id == id));
        else
            throw new DalIDNotFoundException($"Sale with id: {id} was not found");
    }

    public Sale? Read(int id)
    {
        if (DataSource.Sales.Exists(sale => sale != null && sale.Id == id))
            return DataSource.Sales.Find(sale => sale!.Id == id);
        else
            throw new DalIDNotFoundException($"Sale with id: {id} was not found");
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        return DataSource.Sales.FirstOrDefault(filter!);
    }

    Sale? ICrud<Sale>.Read(Func<Sale, bool> filter)
    {
        throw new NotImplementedException();
    }

    public List<Sale?> ReadAll(Func<Sale,bool>?filter=null)
    {
        if (filter != null)
            return DataSource.Sales.Where<Sale>(filter).ToList()!;
        return new List<Sale?>(DataSource.Sales!=null?DataSource.Sales:new List<Sale?>())!;
    }

    public void Update(Sale s)
    {
        if (DataSource.Sales.Exists(sale => sale != null && sale.Id == s.Id))
        {
            Delete(s.Id);
            DataSource.Sales.Add(s);
        }
        else
            throw new DalIDNotFoundException($"Sale with id: {s.Id} was not found");
    }


}
