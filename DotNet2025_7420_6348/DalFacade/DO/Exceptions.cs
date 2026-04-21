using System.Text.Json.Serialization;

namespace DO;

[Serializable]
public class DalIDNotFoundException : Exception
{
    public DalIDNotFoundException(string mes):base(mes)
    {
        
    }
}

[Serializable]
public class DalAlreadyExists : Exception
{
    public DalAlreadyExists(string mes) : base(mes)
    {
        
    }
}

[Serializable]
public class DalConfigExceptions : Exception
{
    public DalConfigExceptions(string mes):base(mes)
    {
        
    }
    public DalConfigExceptions(string mes,Exception ex):base(mes,ex)
    {
        
    }
}