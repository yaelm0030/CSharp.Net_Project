// See https://aka.ms/new-console-template for more information
//using System.Runtime.CompilerServices;


using Dal;
using DalApi;
using DalTest;
using DO;
using System.ComponentModel;
using System.Data;
using System.Threading.Channels;

internal class Program
{
    //private static readonly IDal s_dal = new DalList();
    //private static readonly IDal s_dal = DalXml.DalXml.Instance;
    private static readonly IDal s_dal = DalApi.Factory.Get;


    private static void Main(string[] args)
    {
        try
        {
            //Initialization.Initialize();
            MainMenu();
        }
        catch (DalIDNotFoundException pidnfEx)
        {
            Console.WriteLine(pidnfEx.Message);
        }
        catch (DalAlreadyExists paeEx)
        {
            Console.WriteLine(paeEx.Message);
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public static void MainMenu()
    {
        Console.WriteLine("Choose a department");
        Console.WriteLine("1 for Products");
        Console.WriteLine("2 for Sales");
        Console.WriteLine("3 for Customers");
        Console.WriteLine("4 to Quit");
        int choice;
        int.TryParse(Console.ReadLine(), out choice);
        switch (choice)
        {
            case 1: SubMenuProduct(); break;
            case 2: SubMenuSale(); break;
            case 3: SubMenuCustomer(); break;
            default: break;
        }
    }


    public static int PrintSubMenu(string dep)
    {
        Console.WriteLine($"For viewing all {dep}s press 0");
        Console.WriteLine($"For creating a new {dep} press 1");
        Console.WriteLine($"For getting a specific {dep} press 2");
        Console.WriteLine($"For updating a specific {dep} press 3");
        Console.WriteLine($"For deleting a specific {dep} press 4");
        Console.WriteLine($"For returning to the main menu press 5");
        Console.WriteLine($"For quiting press any other key");

        int choice;
        if(!int.TryParse(Console.ReadLine(), out choice))
            choice = 6;
        return choice;
    }
    private static void SubMenuSale() {
        int choice = PrintSubMenu("sale");
        switch (choice)
        {
            case 0: ReadAll<Sale>(s_dal.Sale); SubMenuSale(); break;
            case 1: AddSale(); SubMenuSale(); break;
            case 2: Read<Sale>(s_dal.Sale); SubMenuSale(); break;
            case 3: UpdateSale(); SubMenuSale(); break;
            case 4: Delete<Sale>(s_dal.Sale); SubMenuSale(); break;
            case 5: MainMenu(); break;
            default: break;
        }
    }
    private static void SubMenuCustomer() {
        int choice = PrintSubMenu("customer");
        switch (choice)
        {
            case 0: ReadAll<Customer>(s_dal.Customer); SubMenuCustomer(); break;
            case 1: AddCustomer(); SubMenuCustomer(); break;
            case 2: Read<Customer>(s_dal.Customer); SubMenuCustomer(); break;
            case 3: UpdateCustomer(); SubMenuCustomer(); break;
            case 4: Delete<Customer>(s_dal.Customer); SubMenuCustomer(); break;
            case 5: MainMenu(); break;
            default: break;
        }
    }
    private static void SubMenuProduct()
    {

        int choice = PrintSubMenu("product");
        switch (choice)
        {
            case 0: ReadAll<Product>(s_dal.Product); SubMenuProduct(); break;
            case 1: AddProduct(); SubMenuProduct(); break;
            case 2: Read<Product>(s_dal.Product); SubMenuProduct(); break;
            case 3: UpdateProduct(); SubMenuProduct(); break;
            case 4: Delete<Product>(s_dal.Product); SubMenuProduct(); break;
            case 5: MainMenu(); break;
            default: break;
        }

    }

    private static Product AskProduct(int code = 0)
    {
        string name;
        Category category;
        double price;
        int amount;
        Console.WriteLine("Insert the name of your product");
        name = Console.ReadLine()!;
        Console.WriteLine("Insert the category: between 0 to 4");
        int cat;
        if (!int.TryParse(Console.ReadLine(), out cat))
            category = 0;
        else
            category = (Category)cat;
        Console.WriteLine("Insert price");
        if (!double.TryParse(Console.ReadLine(), out price))
            price = 5.5;
        Console.WriteLine("Insert amount in stock");
        if (!int.TryParse(Console.ReadLine(), out amount))
            amount = 1;
        return new Product(code, name, category, price, amount);
    }
    private static Sale AskSale(int code = 0)
    {
        int prodId;
        int amount;
        double price;
        bool club;
        Console.WriteLine("Insert product id");
        if (!int.TryParse(Console.ReadLine(), out prodId))
            prodId = 111;
        Console.WriteLine("Insert amount needed");
        if (!int.TryParse(Console.ReadLine(), out amount))
            amount = 2;
        Console.WriteLine("Insert the price after discount");
        if (!double.TryParse(Console.ReadLine(), out price))
            price = 3;
        Console.WriteLine("Do you have to be a club customer?");
        if (!bool.TryParse(Console.ReadLine(), out club))
            club = true;
        return new Sale(code, prodId, amount, price, club, DateTime.Now, DateTime.Now);
    }
    private static Customer AskCustomer(int identity = 0)
    {
        string name;
        string address;
        string phone;
        Console.WriteLine("Insert customer's id");
        if (!int.TryParse(Console.ReadLine(), out identity))
            identity = 0;
        Console.WriteLine("Insert customer's name");
        name = Console.ReadLine()!;
        Console.WriteLine("Insert customer's address");
        address = Console.ReadLine()!;
        Console.WriteLine("Insert customer's phone");
        phone = Console.ReadLine()!;
        return new Customer(identity, name, address, phone);
    }


    private static void AddProduct()
    {
        Product p = AskProduct();
        s_dal.Product.Create(p);
    }
    private static void AddCustomer()
    {
        Customer c = AskCustomer();
        s_dal.Customer.Create(c);
    }
    private static void AddSale()
    {
        Sale s = AskSale();
        s_dal.Sale.Create(s);
    }

    private static void UpdateProduct()
    {
        Console.WriteLine("Insert product ID");
        int id;
        int.TryParse(Console.ReadLine(), out id);
        Product p = AskProduct(id);
        s_dal.Product.Update(p);
    }
    private static void UpdateSale()
    {
        Console.WriteLine("Insert sale ID");
        int id;
        int.TryParse(Console.ReadLine(), out id);
        Sale s = AskSale(id);
        s_dal.Sale.Update(s);
    }
    private static void UpdateCustomer()
    {
        Console.WriteLine("Insert customer ID");
        int id;
        int.TryParse(Console.ReadLine(), out id);
        Customer c = AskCustomer(id);
        s_dal.Customer.Update(c);
    }

    private static void ReadAll<T>(ICrud<T>icrud)
    {
        List<T>lst=icrud.ReadAll();
        foreach (T item in lst)
        {
            Console.WriteLine(item);
        }
    }
    private static void Read<T>(ICrud<T> icrud)
    {
        Console.WriteLine("Insert id");
        int id;
        if (!int.TryParse(Console.ReadLine(), out id))
            id = 111;
        Console.WriteLine(icrud.Read(id));
    }
    private static void Delete<T>(ICrud<T> icrud) {
        Console.WriteLine("Insert id");
        int id;
        if (!int.TryParse(Console.ReadLine(), out id))
            id = 0;
        icrud.Delete(id);
    }
}