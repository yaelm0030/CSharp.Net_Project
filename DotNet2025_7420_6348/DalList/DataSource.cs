using DalApi;

namespace Dal;

internal static class DataSource
{
    internal static List<Customer?> Customers=new List<Customer?>();
    internal static List<Product?> Products = new List<Product?>();
    internal static List<Sale?> Sales = new List<Sale?>();

    internal static class Config{
        internal const int SalesCounter= 0;
        static private int SalesCounterPrivate=SalesCounter;
        //מה צריכה להיות ההרשאה?
        public static int GetSalesCounter { get { return SalesCounterPrivate++; } }
    }
}
