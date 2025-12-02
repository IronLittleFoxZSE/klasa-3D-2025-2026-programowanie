namespace PolymorphismConsoleApp;

internal class Rectangle : Trapeze, IWorkOnFiles
{
    //protected int sideA, sideB;
    //protected string name;

    public Rectangle(int a, int b):base(a, b, a, b, b)
    {
        name = "prostokąt";
    }

    /*
    public new void ShowInfo()
    {
        Console.WriteLine($"Obiekt {name}:");
        Console.WriteLine($"Bok a = {sideA}");
        Console.WriteLine($"Bok b = {sideB}");
        Console.WriteLine($"Obwód = {GetPerimeter()}");
        Console.WriteLine($"Pole = {GetArea()}");
        Console.WriteLine();
    }
    */

    /*
    public new int GetPerimeter()
    {
        return 2 * sideA + 2 * sideB;
    }
    */

    public override int GetArea()
    {
        return sideA * sideB;
    }
    
}


/*

        ---------------------
        |                   |
  a     |                   |
        |                   |
        ---------------------
                   b


*/
