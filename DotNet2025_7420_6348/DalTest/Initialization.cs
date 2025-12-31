using DO;
using DalApi;
using Dal;
using System.Runtime.CompilerServices;
namespace DalTest;

public static class Initialization
{
    private static IDal s_dal=new DalList();
    //רשימה של המוצרים הקיימים בשביל להשתמש בהם באתחול המבצעים
    private static void CreateSales()
    {
        s_dal.Sale.Create(new Sale(0, s_dal.Product.Read(22000000).Id,2,3.4,true,DateTime.Now,DateTime.Now.AddDays(7)));
        s_dal.Sale.Create(new Sale(0, s_dal.Product.Read(22000001).Id, 4, 10, true, DateTime.Now, DateTime.Now.AddDays(7)));
        s_dal.Sale.Create(new Sale(0, s_dal.Product.Read(22000002).Id, 1, 6.8, true, DateTime.Now, DateTime.Now.AddDays(7)));
        s_dal.Sale.Create(new Sale(0, s_dal.Product.Read(22000003).Id, 10, 10, true, DateTime.Now, DateTime.Now.AddDays(7)));
    }

    private static void CreateProducts()
    {
        s_dal.Product.Create(new Product(1,"",Category.cat1,1.1,4));
        s_dal.Product.Create(new Product(1,"",Category.cat1,1.1,4));
        s_dal.Product.Create(new Product(1,"",Category.cat1,1.1,4));
        s_dal.Product.Create(new Product(1,"",Category.cat1,1.1,4));
    }

    private static void CreateCustomers()
    {
        s_dal.Customer.Create(new Customer(216086348,"Yael Makovetzky","Shderot Yehezkel 13","0534100030"));
        s_dal.Customer.Create(new Customer(346007420, "Chavi Koninski", "Meromei Sade 36", "0534120828"));
        s_dal.Customer.Create(new Customer(065677858, "Chaya Makovetzky", "Shderot Yehezkel 13", "0527657760"));
        s_dal.Customer.Create(new Customer(326287720, "Efrat Gross", "Rashbi 26", "0548501231"));
    }

    //static?
    public static void Initialize(IDal s_dal_f)
    {
        s_dal = s_dal_f;
        CreateProducts();
        CreateCustomers();
        CreateSales();
    }
}
