using DO;

namespace DalApi;

public interface ICustomer
{
    //האם תקין לשנות את הרשאת הישויות בdo לpublic? כדי להשתמש בהן כאן? לעדכן את חני ואסתי
    int Create(Customer c);
    Customer? Read(int id);
    List<Customer> ReadAll();
    void Update(Customer c);
    void Delete(int id);
}
