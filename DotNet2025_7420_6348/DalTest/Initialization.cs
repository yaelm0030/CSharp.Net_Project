using DO;
using DalApi;
using Dal;
using System.Runtime.CompilerServices;
namespace DalTest;

public static class Initialization
{
    private static IDal s_dal;
    //רשימה של המוצרים הקיימים בשביל להשתמש בהם באתחול המבצעים
    private static void CreateSales()
    {
        s_dal.Sale.Create(new Sale(0, s_dal.Product.Read(220).Id,2,3.4,true,DateTime.Now,DateTime.Now.AddDays(7)));
        s_dal.Sale.Create(new Sale(0, s_dal.Product.Read(220).Id, 4, 10, true, DateTime.Now, DateTime.Now.AddDays(7)));
        s_dal.Sale.Create(new Sale(0, s_dal.Product.Read(220).Id, 1, 6.8, true, DateTime.Now, DateTime.Now.AddDays(7)));
        s_dal.Sale.Create(new Sale(0, s_dal.Product.Read(220).Id, 10, 10, true, DateTime.Now, DateTime.Now.AddDays(7)));
    }

    private static void CreateProducts()
    {
        s_dal.Product.Create(new Product(1,"productname1",Category.cat1,1.1,4));
        s_dal.Product.Create(new Product(1,"productname2",Category.cat1,1.1,4));
        s_dal.Product.Create(new Product(1,"productname3",Category.cat1,1.1,4));
        s_dal.Product.Create(new Product(1,"productname4",Category.cat1,1.1,4));
    }

    private static void CreateCustomers()
    {
        s_dal.Customer.Create(new Customer(216086348,"Yael Makovetzky","Shderot Yehezkel 13","0534100030"));
        s_dal.Customer.Create(new Customer(346007420, "Chavi Koninski", "Meromei Sade 36", "0534120828"));
        s_dal.Customer.Create(new Customer(065677858, "Chaya Makovetzky", "Shderot Yehezkel 13", "0527657760"));
        s_dal.Customer.Create(new Customer(326287720, "Efrat Gross", "Rashbi 26", "0548501231"));
    }

    public static void Initialize()
    {
        s_dal = DalApi.Factory.Get;
        CreateProducts();
        CreateCustomers();
        CreateSales();
    }
}
