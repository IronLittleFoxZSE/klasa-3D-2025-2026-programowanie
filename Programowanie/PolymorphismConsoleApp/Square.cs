namespace PolymorphismConsoleApp;

internal class Square : Rectangle
{
    public Square(int a):base(a, a)
    {
        name = "kwadrat";
    }

    /*
    public new void ShowInfo()
    {
        Console.WriteLine("Obiekt kwadrat:");
        Console.WriteLine($"Bok a = {sideA}");
        Console.WriteLine($"Obwód = {GetPerimeter()}");
        Console.WriteLine($"Pole = {GetArea()}");
        Console.WriteLine();
    }
    */
}

/*

        ---------------
        |             |
  a     |             |
        |             |
        ---------------
                a


*/

