
using PolymorphismConsoleApp;
using static System.Net.Mime.MediaTypeNames;

Rectangle rectangle = new Rectangle(5,9);

rectangle.ShowInfo();

Trapeze trapeze = new(15, 16, 87, 4, 15);

trapeze.ShowInfo();


Square square = new(4);
square.ShowInfo();

Triangle triangle = new(1, 2, 3, 5);
triangle.ShowInfo();

Figure figure;// = new Figure();

Cat cat = new Cat("Filemon");
cat.Meow();

//int x = 5;
//float y = x;

//Square s = new Square(4);
//Trapeze t = new Trapeze(1, 1, 1, 1, 1);

//t = s; //można ponieważ t jest Trapez a s jest między innymi też Trapez
//s = t; // błąd ponieważ s jest Square a t jest Trapez i Object

//Test1(rectangle);
//Test2(square);
Test3(rectangle);
Test3(square);
Test3(trapeze);

/*
void Test1(Rectangle r)
{
    Console.WriteLine($"Obwód: {r.GetPerimeter()}");
    Console.WriteLine($"Pole: {r.GetArea()}");
}

void Test2(Square s)
{
    Console.WriteLine($"Obwód: {s.GetPerimeter()}");
    Console.WriteLine($"Pole: {s.GetArea()}");
}
*/
void Test3(Trapeze t)
{
    Console.WriteLine($"Obwód: {t.GetPerimeter()}");
    Console.WriteLine($"Pole: {t.GetArea()}");
}

Test4(rectangle);
Test4(square);
Test4(trapeze);
Test4(triangle);
void Test4(Figure t)
{
    Console.WriteLine($"Obwód: {t.GetPerimeter()}");
    Console.WriteLine($"Pole: {t.GetArea()}");
}

Test5(rectangle);
Test5(square);
Test5(trapeze);
Test5(triangle);
void Test5(Figure f)
{
    f.SaveToFile();
}

Test6(rectangle);
Test6(square);
Test6(trapeze);
Test6(triangle);
Test6(cat);
void Test6(IWorkOnFiles wof)
{
    wof.SaveToFile();
}


