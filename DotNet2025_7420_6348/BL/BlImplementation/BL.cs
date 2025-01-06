using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class BL : IBl
    {
        public ICustomer Customer => new CustomerImplementation();

        public ISale Sale => new SaleImplementation();

        public IProduct Product => new ProductImplementation();

        public IOrder Order => new OrderImplementation();
    }


}
