using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ProductIdNotFoundException:Exception
    {
        public ProductIdNotFoundException(int id)
            : base($"Product With Id {id} Was Not Found") { }

        public ProductIdNotFoundException(int id, Exception innerException)
            : base($"Product With Id {id} Was Not Found", innerException) { }
    }
    public class ProductAlreadyExistsException : Exception
    {
        public ProductAlreadyExistsException(string message)
            :base(message) { }

        public ProductAlreadyExistsException(string message, Exception innerException)
            : base(message, innerException) { }
    }
    public class SaleIdNotFoundException : Exception
    {
        public SaleIdNotFoundException(int id)
            : base($"Sale With Id {id} Was Not Found") { }

        public SaleIdNotFoundException(int id, Exception innerException)
            : base($"Sale With Id {id} Was Not Found", innerException) { }
    }
    public class SaleAlreadyExistsException : Exception
    {
        public SaleAlreadyExistsException(string message)
            : base(message) { }

        public SaleAlreadyExistsException(string message, Exception innerException)
            : base(message, innerException) { }
    }
    public class CustomerIdNotFoundException : Exception
    {
        public CustomerIdNotFoundException(int id)
            : base($"Customer With Id {id} Was Not Found") { }

        public CustomerIdNotFoundException(int id, Exception innerException)
            : base($"Customer With Id {id} Was Not Found", innerException) { }
    }

    public class CustomerAlreadyExistsException: Exception
    {
        public CustomerAlreadyExistsException(string message)
            : base(message) { }

        public CustomerAlreadyExistsException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
