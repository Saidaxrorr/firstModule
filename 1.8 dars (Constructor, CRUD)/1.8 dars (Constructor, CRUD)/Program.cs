namespace _1._8_dars__Constructor__CRUD_;

internal class Program
{
    static void Main(string[] args)
    {

        var planet1 = new Planet("Earth","A good place to live", 4.5, true, true, 9);
        Console.WriteLine("Name: " + planet1.Name);
        

    }
}
