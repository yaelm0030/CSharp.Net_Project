using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO;
[Serializable]
public class BlProductIdNotFoundException : Exception
{
    public BlProductIdNotFoundException(int id)
        : base($"Product With Id {id} Was Not Found") { }

    public BlProductIdNotFoundException(int id, Exception innerException)
        : base($"Product With Id {id} Was Not Found", innerException) { }
}
public class BlProductAlreadyExistsException : Exception
{
    public BlProductAlreadyExistsException(string message)
        : base(message) { }

    public BlProductAlreadyExistsException(string message, Exception innerException)
        : base(message, innerException) { }
}
public class BlSaleIdNotFoundException : Exception
{
    public BlSaleIdNotFoundException(int id)
        : base($"Sale With Id {id} Was Not Found") { }

    public BlSaleIdNotFoundException(int id, Exception innerException)
        : base($"Sale With Id {id} Was Not Found", innerException) { }
}
public class BlSaleAlreadyExistsException : Exception
{
    public BlSaleAlreadyExistsException(string message)
        : base(message) { }

    public BlSaleAlreadyExistsException(string message, Exception innerException)
        : base(message, innerException) { }
}
public class BlCustomerIdNotFoundException : Exception
{
    public BlCustomerIdNotFoundException(int id)
        : base($"Customer With Id {id} Was Not Found") { }

    public BlCustomerIdNotFoundException(int id, Exception innerException)
        : base($"Customer With Id {id} Was Not Found", innerException) { }
}

public class BlCustomerAlreadyExistsException : Exception
{
    public BlCustomerAlreadyExistsException(string message)
        : base(message) { }

    public BlCustomerAlreadyExistsException(string message, Exception innerException)
        : base(message, innerException) { }
}
public class BlConfigExceptions : Exception
{
    public BlConfigExceptions(string mes):base(mes)
    {
        
    }
    public BlConfigExceptions(string mes,Exception ex):base(mes,ex)
    {
        
    }
}
public class NoProductsInStock : Exception
{
    public NoProductsInStock(string mes) : base(mes)
    {

    }
    public NoProductsInStock(string mes, Exception ex) : base(mes, ex)
    {

    }
}
