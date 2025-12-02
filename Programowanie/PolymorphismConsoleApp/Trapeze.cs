namespace PolymorphismConsoleApp;

internal class Trapeze : Figure
{
    protected int sideA, sideB, sideC, sideD;
    protected int height;
    

    public Trapeze(int a, int b, int c, int d, int h)
    {
        sideA = a;
        sideB = b;
        sideC = c;
        sideD = d;
        height = h;
        name = "trapez";
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Obiekt {name}:");
        Console.WriteLine($"Bok a = {sideA}");
        Console.WriteLine($"Bok b = {sideB}");
        Console.WriteLine($"Bok c = {sideC}");
        Console.WriteLine($"Bok d = {sideD}");
        Console.WriteLine($"Wysokość = {height}");
        Console.WriteLine($"Obwód = {GetPerimeter()}");
        Console.WriteLine($"Pole = {GetArea()}");
        Console.WriteLine();
    }

    public override int GetPerimeter()
    {
        return sideA + sideB + sideC + sideD;
    }

    public override int GetArea()
    {
        return (sideB + sideD) * height / 2;
    }

    public override void SaveToFile()
    {
        //zapis do pliku
    }
}

/*
                    d
            -----------------
           /                 \
     a    /                   \  c
         /                     \
        -------------------------
                    b
*/