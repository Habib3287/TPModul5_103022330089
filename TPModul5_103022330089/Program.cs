// See https://aka.ms/new-console-template for more information

public class HaloGeneric {
    public void SapaUser<T>(T User) { 
        Console.WriteLine($"Halo User " + User);
    }  
}

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {data}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Haafizd Alhabib Azwir");

        DataGeneric<string> dataNIM = new DataGeneric<string>("103022330089");
        dataNIM.PrintData();
    }
}