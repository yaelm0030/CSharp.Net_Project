namespace DalApi;

using DO;

public interface ISale:ICrud<Sale>
{
    int Create(Sale s);
    Sale? Read(int id);
    List<Sale> ReadAll();
    void Update(Sale sale);
    void Delete(int id);
}
