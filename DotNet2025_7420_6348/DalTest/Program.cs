//// See https://aka.ms/new-console-template for more information
//using System.Runtime.CompilerServices;

//Console.WriteLine("Hello, World!");

using Dal;
using DalApi;
using DalTest;

internal class Program
{
    private static ISale s_dalSale = new SaleImplementation();
    private static ICustomer s_dalCustomer = new CustomerImplementation();
    private static IProduct s_dalProduct = new ProductImplementation();

    public static void main()
    {
        Initialization.Initialize(s_dalSale,s_dalCustomer,s_dalProduct);
    }

}