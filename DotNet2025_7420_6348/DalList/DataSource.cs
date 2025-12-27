using DalApi;
using DO;//לבדוק נכונות
namespace Dal;

public static class DataSource
{
    internal static List<Customer?> Customers=new List<Customer?>();
    internal static List<Product?> Products = new List<Product?>();
    internal static List<Sale?> Sales = new List<Sale?>();

    internal static class Config{
        internal const int SalesCounter= 11000;
        static private int SalesCounterPrivate=SalesCounter;
        //מה צריכה להיות ההרשאה?
        public static int GetSalesCounter { get { return SalesCounterPrivate++; } }

        internal const int ProductCounter = 22000000;
        static private int ProductCounterPrivate = ProductCounter;
        //מה צריכה להיות ההרשאה?
        public static int GetProductCounter { get { return ProductCounterPrivate++; } }
    }
}
