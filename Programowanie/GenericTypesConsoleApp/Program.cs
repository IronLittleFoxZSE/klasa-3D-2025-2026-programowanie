
using GenericTypesConsoleApp;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

ContainerInt container = new ContainerInt(45);
container.Show();

ContainerString secondContainer = new ContainerString("Ala ma kota");
secondContainer.Show();


Container<int> thirdContainer = new Container<int>(78);
thirdContainer.Show();
Container<string> fourthContainer = new Container<string>("Ala ma kota");
fourthContainer.Show();

Container<double> container5 = new Container<double>(5.9);
fourthContainer.Show();


//-----------------------------------------------------------------------------------------------------

Action firstAction = null;
firstAction = TestMethod;
firstAction = () => { Console.WriteLine("To jest testowa metoda"); };
firstAction = () => Console.WriteLine("To jest testowa metoda");
if (firstAction is not null)
    firstAction();
//TestMethod = firstAction;

Action<int> secondAction = null;
secondAction = TestSecondMethod;
secondAction = (int value) => { Console.WriteLine($"To jest testowa metoda wywołana z parametrem {value}"); };
secondAction = (value) => Console.WriteLine($"To jest testowa metoda wywołana z parametrem {value}");
if (secondAction is not null)
    secondAction(4);

Func<double> firstFunc = null;
firstFunc = TestThirdMethod;
firstFunc = () => { return 4.7; };
firstFunc = () =>  /*return*/ 4.7;
double x;
if (firstFunc is not null)
    x = firstFunc();

Func<string, int> secondFunc = null;
secondFunc = TestFourthMethod;
secondFunc = (string text) => { return int.Parse(text); };
secondFunc = (text) => { return int.Parse(text); };
secondFunc = (text) => int.Parse(text);
int y;
if (secondFunc is not null)
    y = secondFunc("5");


Console.WriteLine($"Maksymalna to: {GetMaxInt(2, 7)}");
Console.WriteLine($"Maksymalna to: {GetMaxGen<int>(2, 7)}");
Console.WriteLine($"Maksymalna to: {GetMaxGen(2, 7)}");

Console.WriteLine($"Maksymalna to: {GetMaxDouble(2.5, 1.7)}");
Console.WriteLine($"Maksymalna to: {GetMaxGen<double>(2.5, 1.7)}");
Console.WriteLine($"Maksymalna to: {GetMaxGen(2.5, 1.7)}");

Console.WriteLine($"Maksymalna to: {GetMax(2.5, 1.7, cmpDouble)}");
Console.WriteLine($"Maksymalna to: {GetMax(2.5, 1.7, (a, b) => a > b)}");

Test t1, t2;
t1 = new Test() { MyProperty = 2 };
t2 = new Test() { MyProperty = 6 };

//Console.WriteLine($"Maksymalna to: {GetMaxGen(t1, t2)}");
Console.WriteLine($"Maksymalna to: {GetMax(t1, t2, cmpTest)}");

bool cmpTest(Test x, Test y)
{
    return x.MyProperty > y.MyProperty;
}

bool cmpDouble(double x, double y)
{
    return x > y;
}

T GetMax<T>(T a, T b, Func<T, T, bool> cmp)
{
    T max;

    if (cmp(a, b))
        max = a;
    else
        max = b;
    return max;
}

T GetMaxGen<T>(T a, T b) where T : INumber<T>
{
    T max;

    if (a > b)
        max = a;
    else
        max = b;
    return max;
}

int GetMaxInt(int a, int b)
{
    int max;

    if (a > b)
        max = a;
    else
        max = b;
    return max;
}

double GetMaxDouble(double a, double b)
{
    double max;

    if (a > b)
        max = a;
    else
        max = b;
    return max;
}

void TestMethod()
{
    Console.WriteLine("To jest testowa metoda");
}

void TestSecondMethod(int value)
{
    Console.WriteLine($"To jest testowa metoda wywołana z parametrem {value}");
}

double TestThirdMethod()
{
    return 4.7;
}

int TestFourthMethod(string text)
{
    return int.Parse(text);
}


class Test//: INumber<Test>
{
    public int MyProperty { get; set; }
}