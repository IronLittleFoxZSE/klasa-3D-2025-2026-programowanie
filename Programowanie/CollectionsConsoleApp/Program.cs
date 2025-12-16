

//c++
//typ nazwa[rozmiar];
//nazwa[numerKomórki] = wartoœæ;

//C#
//typ[] nazwa = new typ[rozmiar];

int[] tab = new int[10];
tab[3] = 45;

int[] tab2 = new int[20];
//przepisaæ z tab do tab2
tab = tab2;

string[] tab3 = { "Ala", "Ola", "Ula", "Ela", "Tola" };
//int length = 5;
string[] tab4 = ["Ala", "Ola", "Ula"]; //.net8 C#12

for (int i = 0; i < tab3.Length; i++)
    Console.WriteLine(tab3[i]);

//tab3[9] = "ABCD"; //B£¥D

List<int> firstList = new List<int>();
firstList.Add(5);
firstList.Add(68);
firstList.Add(7);
firstList.Add(45);

firstList[1] = 78;
//firstList[8] = 99;

Console.WriteLine("Zawartoœæ pierwszej kolekcji:");
for(int i = 0; i < firstList.Count; i++)
{
    Console.WriteLine(firstList[i]);
}

firstList.Clear();

int number;
do
{
    Console.WriteLine("Podaj liczbê:");
    number = int.Parse(Console.ReadLine());
    firstList.Add(number);
} while (number != 0);

Console.WriteLine("Zawartoœæ kolekcji z liczbami u¿ytkownika:");
for (int i = 0; i < firstList.Count; i++)
{
    Console.WriteLine(firstList[i]);
}

Console.WriteLine("Zawartoœæ kolekcji z liczbami u¿ytkownika:");
foreach(int num in firstList)
{
    Console.WriteLine(num);
}

firstList.Insert(1, 5);

Console.WriteLine("Zawartoœæ kolekcji z liczbami u¿ytkownika:");
foreach (int num in firstList)
{
    Console.WriteLine(num);
}

firstList.Remove(5);
Console.WriteLine("Zawartoœæ kolekcji z liczbami u¿ytkownika:");
foreach (int num in firstList)
{
    Console.WriteLine(num);
}