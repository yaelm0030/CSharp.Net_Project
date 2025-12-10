using DO;

namespace DalApi;

public interface IProduct { 
    //האם תקין לשנות את הרשאת הישויות בdo לpublic? כדי להשתמש בהן כאן? לעדכן את חני ואסתי
    int Create(Product p);
    Product? Read(int id);
    List<Product> ReadAll();
    void Update(Product p);
    void Delete(int id);
}
