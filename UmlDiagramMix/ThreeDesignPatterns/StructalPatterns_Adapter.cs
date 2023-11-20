using System;

public class ExistingClass
{
    public void Method(int data)
    {
        Console.WriteLine($"ExistingClass: Metod in   data - {data}");
    }
}

public interface IService
{
    void ServiceMethod(string specialData);
}

public class Service : IService
{
    public void ServiceMethod(string specialData)
    {
        Console.WriteLine($"Service: ServiceMetod in special data - {specialData}");
    }
}

public class Adapter : ExistingClass
{
    private readonly IService _service;

    public Adapter(IService service)
    {
        _service = service;
    }

    public new void Method(int data)
    {
        string specialData = convertToServiceFormat(data);

        _service.ServiceMethod(specialData);
    }

    private string convertToServiceFormat(int data)
    {
        return data.ToString(); 
    }
}

public class Client_

{
    public void Adapter_()
    {
        ExistingClass existing = new ExistingClass();

        IService service = new Service();

        Adapter adapter = new Adapter(service);

        adapter.Method(123);

        existing.Method(456); //456 
    }
}
