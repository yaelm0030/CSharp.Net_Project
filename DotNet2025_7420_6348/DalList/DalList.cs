using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    internal sealed class DalList : IDal
    {
        private DalList()
        {
            
        }
        private static DalList instance { get; } = new DalList();
        public static DalList Instance { get { return instance; } }
        public ICustomer Customer =>new CustomerImplementation();
        public ISale Sale => new SaleImplementation();
        public IProduct Product => new ProductImplementation();

    }
}
