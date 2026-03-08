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