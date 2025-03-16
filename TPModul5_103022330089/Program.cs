// See https://aka.ms/new-console-template for more information

public class HaloGeneric {
    public void SapaUser<T>(T User) { 
        Console.WriteLine($"Halo User " + User);
    }  
}

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Haafizd Alhabib Azwir");
    }
}