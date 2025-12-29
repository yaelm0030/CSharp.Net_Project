using DO;
using DalApi;
using Dal;
using System.Runtime.CompilerServices;
namespace DalTest;

public static class Initialization
{
    private static ISale? s_dalSale;
    private static ICustomer? s_dalCustomer;
    private static IProduct? s_dalProduct;

    //רשימה של המוצרים הקיימים בשביל להשתמש בהם באתחול המבצעים
    private static void CreateSales()
    {
        s_dalSale.Create(new Sale(1,s_dalProduct.Read(111).Id,2,3.4,true,DateTime.Now,DateTime.Now.AddDays(7)));
        s_dalSale.Create(new Sale(2, s_dalProduct.Read(112).Id, 4, 10, true, DateTime.Now, DateTime.Now.AddDays(7)));
        s_dalSale.Create(new Sale(3, s_dalProduct.Read(113).Id, 1, 6.8, true, DateTime.Now, DateTime.Now.AddDays(7)));
        s_dalSale.Create(new Sale(4,s_dalProduct.Read(114).Id, 10, 10, true, DateTime.Now, DateTime.Now.AddDays(7)));
    }

    private static void CreateProducts()
    {
        s_dalProduct.Create(new Product(111,"",Category.cat1,1.1,4));
        s_dalProduct.Create(new Product(112,"",Category.cat1,1.1,4));
        s_dalProduct.Create(new Product(113,"",Category.cat1,1.1,4));
        s_dalProduct.Create(new Product(114,"",Category.cat1,1.1,4));
    }

    private static void CreateCustomers()
    {
        s_dalCustomer.Create(new Customer(216086348,"Yael Makovetzky","Shderot Yehezkel 13","0534100030"));
        s_dalCustomer.Create(new Customer(346007420, "Chavi Koninski", "Meromei Sade 36", "0534120828"));
        s_dalCustomer.Create(new Customer(065677858, "Chaya Makovetzky", "Shderot Yehezkel 13", "0527657760"));
        s_dalCustomer.Create(new Customer(326287720, "Efrat Gross", "Rashbi 26", "0548501231"));
    }

    //static?
    public static void Initialize(ISale s_dalSalef, ICustomer s_dalCustomerf, IProduct s_dalProductf)
    {
        s_dalSale = s_dalSalef;
        s_dalCustomer = s_dalCustomerf;
        s_dalProduct = s_dalProductf;
        CreateProducts();
        CreateCustomers();
        CreateSales();
    }
}
