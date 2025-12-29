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
    private static ISale s_dalSale = new SaleImplementation();
    private static ICustomer s_dalCustomer = new CustomerImplementation();
    private static IProduct s_dalProduct = new ProductImplementation();

    private static void Main(string[] args)
    {
        try
        {
            Initialization.Initialize(s_dalSale, s_dalCustomer, s_dalProduct);
            MainMenu();
        }
        catch (ProductIdNotFoundException pidnfEx)
        {
            Console.WriteLine(pidnfEx.Message);
        }
        catch (SaleIdNotFoundException sidnfEx)
        {
            Console.WriteLine(sidnfEx.Message);
        }
        catch (CustomerIdNotFoundException cidnfEx)
        {
            Console.WriteLine(cidnfEx.Message);
        }
        catch (ProductAlreadyExistsException paeEx)
        {
            Console.WriteLine(paeEx.Message);
        }
        catch (SaleAlreadyExistsException saeEx)
        {
            Console.WriteLine(saeEx.Message);
        }
        catch (CustomerAlreadyExistsException caeEx)
        {
            Console.WriteLine(caeEx.Message);
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
            case 1: SubMenuProduct(s_dalProduct); break;
            case 2: SubMenuSale(s_dalSale); break;
            case 3: SubMenuCustomer(s_dalCustomer); break;
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
        int.TryParse(Console.ReadLine(), out choice);
        return choice;
    }

    private static void SubMenuSale(ISale sSale) {
        int choice = PrintSubMenu("sale");
        switch (choice)
        {
            case 0: ReadAllSales(sSale.ReadAll()); SubMenuSale(sSale); break;
            case 1: AddSale(sSale); SubMenuSale(sSale); break;
            case 2: ReadSale(sSale); SubMenuSale(sSale); break;
            case 3: UpdateSale(sSale); SubMenuSale(sSale); break;
            case 4: DeleteSale(sSale); SubMenuSale(sSale); break;
            case 5: MainMenu(); break;
            default: break;
        }
    }
    private static void SubMenuCustomer(ICustomer cCustomer) {
        int choice = PrintSubMenu("customer");
        switch (choice)
        {
            case 0: ReadAllCustomers(cCustomer.ReadAll()); SubMenuCustomer(cCustomer); break;
            case 1: AddCustomer(cCustomer); SubMenuCustomer(cCustomer); break;
            case 2: ReadCustomer(cCustomer); SubMenuCustomer(cCustomer); break;
            case 3: UpdateCustomer(cCustomer); SubMenuCustomer(cCustomer); break;
            case 4: DeleteCustomer(cCustomer); SubMenuCustomer(cCustomer); break;
            case 5: MainMenu(); break;
            default: break;
        }
    }

    private static void SubMenuProduct(IProduct pProduct) {

        int choice = PrintSubMenu("product");
        switch (choice)
        {
            case 0:ReadAllProducts(pProduct.ReadAll()); SubMenuProduct( pProduct); break;
            case 1:AddProduct(pProduct); SubMenuProduct(pProduct); break;
            case 2:ReadProduct(pProduct); SubMenuProduct(pProduct); break;
            case 3:UpdateProduct(pProduct); SubMenuProduct(pProduct); break;
            case 4:DeleteProduct(pProduct); SubMenuProduct(pProduct); break;
            case 5:MainMenu();break;
            default: break;
        }

    }
    private static void AddProduct(IProduct iproduct)
    {
        Product p = AskProduct();
        iproduct.Create(p);
    }
    private static void AddCustomer(ICustomer icus)
    {
        Customer c = AskCustomer();
        icus.Create(c);
    }
    private static void AddSale(ISale isale)
    {
        Sale s = AskSale();
        isale.Create(s);
    }
    private static void ProductMenu() { }
    private static Product AskProduct(int code = 0) {
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
    private static Sale AskSale(int code = 0) {
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
        return new Sale(code, prodId, amount, price, club);
    }
    private static Customer AskCustomer(int identity=0) {
        int id;
        string name;
        string address;
        string phone;
        Console.WriteLine("Insert customer's id");
        if (!int.TryParse(Console.ReadLine(), out id))
            id = 0;
        Console.WriteLine("Insert customer's name");
        name = Console.ReadLine()!;
        Console.WriteLine("Insert customer's address");
        address = Console.ReadLine()!;
        Console.WriteLine("Insert customer's phone");
        phone = Console.ReadLine()!;
        return new Customer(id, name, address, phone);
    }
    private static void ReadProduct(IProduct pr)
    {
        Console.WriteLine("Insert product id");
        int id;
        if (!int.TryParse(Console.ReadLine(), out id))
            id = 111;
        Console.WriteLine(pr.Read(id));
    }
    private static void ReadSale(ISale sSale)
    {
        Console.WriteLine("Insert sale id");
        int id;
        if (!int.TryParse(Console.ReadLine(), out id))
            id = 0;
        Console.WriteLine(sSale.Read(id));
    }
    private static void ReadCustomer(ICustomer customer)
    {
        Console.WriteLine("Insert customer id");
        int id;
        if (!int.TryParse(Console.ReadLine(), out id))
            id = 111;
        Console.WriteLine(customer.Read(id));
    }

    private static void UpdateProduct(IProduct iprod) {
        Product p = AskProduct();
        iprod.Update(p);
    }
    private static void UpdateSale(ISale isale) {
        Sale s = AskSale();
        isale.Update(s);
    }
    private static void UpdateCustomer(ICustomer icus) {
        Customer c = AskCustomer();
        icus.Update(c);
    }
    private static void ReadAllProducts(List<Product> products) {
        foreach(Product p in products)
        {
            Console.WriteLine(p);
        }
    }
    private static void ReadAllSales(List<Sale> sales) {
        foreach(Sale s in sales)
        {
            Console.WriteLine(s);
        }
    }
    private static void ReadAllCustomers(List<Customer>customers) {
        foreach(Customer c in customers)
        {
            Console.WriteLine(c);
        }
    }
    //למה הקוד הכפול? פונקציות שעושות את אותן פעולות
    private static void ReadAllProducts(IProduct pr) {
        List<Product> products=pr.ReadAll();
        ReadAllProducts(products);
    }
    private static void ReadAllSales(ISale sSale) {
        List<Sale> sales = sSale.ReadAll();
        ReadAllSales(sales);
    }
    private static void ReadAllCustomers(ICustomer cust) {
        List<Customer> customers = cust.ReadAll();
        ReadAllCustomers(customers);
    }

    private static void DeleteProduct(IProduct product) {
        Console.WriteLine("Insert product id");
        int id;
        if (!int.TryParse(Console.ReadLine(), out id))
            id = 0;
        product.Delete(id);
    }
    private static void DeleteSale(ISale sSale) {
        Console.WriteLine("Insert sale id");
        int id;
        if (!int.TryParse(Console.ReadLine(), out id))
            id = 0;
        sSale.Delete(id);
    }
    private static void DeleteCustomer(ICustomer customer) {
        Console.WriteLine("Insert customer id");
        int id;
        if (!int.TryParse(Console.ReadLine(), out id))
            id = 0;
        customer.Delete(id);
    }

}