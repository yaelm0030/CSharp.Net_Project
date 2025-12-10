namespace DalApi;

using DO;

public interface ISale
{
    //האם תקין לשנות את הרשאת הישויות בdo לpublic? כדי להשתמש בהן כאן? לעדכן את חני ואסתי
    int Create(Sale s);
    Sale? Read(int id);
    List<Sale> ReadAll();
    void Update(Sale sale);
    void Delete(int id);
}
