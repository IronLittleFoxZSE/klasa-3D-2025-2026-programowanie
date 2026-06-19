
//using LinqConsoleApp;

//new Podstawa().Test();


// Kolekcja przyk³adowych osób
using LinqConsoleApp;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

var people = new List<Person>
    {
        new() { Id=1, FirstName="Anna",  LastName="Nowak",    Age=29, Gender=Gender.Female, City="Kielce", Salary=8200m,  Skills=["C#", "LINQ", "SQL"] },
        new() { Id=2, FirstName="Marek", LastName="Kowalski", Age=43, Gender=Gender.Male,   City="Warszawa", Salary=15000m, Skills=["Azure", "C#", "DevOps"] },
        new() { Id=3, FirstName="Ewa",   LastName="Wiœniewska",Age=35, Gender=Gender.Female, City="Kraków", Salary=9800m,  Skills=["JavaScript", "React"] },
        new() { Id=4, FirstName="Jan",   LastName="Zieliñski", Age=43, Gender=Gender.Male,   City="Gdañsk", Salary=12000m, Skills=["C#", "SQL"] },
        new() { Id=5, FirstName="Ola",   LastName="Maj",       Age=26, Gender=Gender.Female, City="Kielce", Salary=7200m,  Skills=["Python", "ML"] },
        new() { Id=6, FirstName="Piotr", LastName="Lewandowski",Age=37,Gender=Gender.Male,   City="Warszawa", Salary=13400m, Skills=["C#", "LINQ", "Azure"] },
        new() { Id=7, FirstName="Iga",   LastName="Kowal",     Age=31, Gender=Gender.Female, City="Kraków", Salary=9900m,  Skills=["Go", "Kubernetes"] },
        new() { Id=8, FirstName="Tomek", LastName="Sikora",    Age=29, Gender=Gender.Male,   City="Kielce", Salary=8800m,  Skills=["C#", "MAUI", "Bluetooth"] },
    };

var cities = new[]
{
    new { City = "Kielce",    Region = "Œwiêtokrzyskie" },
    new { City = "Warszawa",  Region = "Mazowieckie" },
    new { City = "Kraków",    Region = "Ma³opolskie" },
    new { City = "Wieliczka", Region = "Ma³opolskie" },
    new { City = "Gdañsk",    Region = "Pomorskie" }
};


//FILTRACJA

/*
select *
from people
where City == "Kielce"
 */
var fromKielce = people.Where(p => p.City == "Kielce");
Print("Osoby z Kielc (Where)", fromKielce);

/*
 select *
from people
where Gender == Gender.Female
 */
var onlyFemales = people.Where(p => p.Gender == Gender.Female);
Print("Tylko kobiety", onlyFemales);


//SORTOWANIE

/*
select *
from people
order by Salary

*/

var orderedBySalary = people.OrderBy(p => p.Salary);
Print("Posortowane po wyp³acie", orderedBySalary);

/*
select *
from people
order by Salary desc

*/

var orderedBySalaryDesc = people.OrderByDescending(p => p.Salary);
Print("Posortowane po wyp³acie malej¹co", orderedBySalaryDesc);

/*
select *
from people
order by Age, Salary desc

*/

var orderByAgeAndSalary = people.OrderBy(p => p.Age).ThenByDescending(p => p.Salary);
Print("Posortowane po wieku i wyp³acie", orderByAgeAndSalary);

//AGREGACJA

/*
select count(*), avg(Salary), min(Age), max(Age), sum(Salary)
from people
*/

var countAll = people.Count();
var avgSalary = people.Average(p => p.Salary);
var minAge = people.Min(p => p.Age);
var maxAge = people.Max(p => p.Age);
var totalSalary = people.Sum(p => p.Salary);
Console.WriteLine($"\nAGREGACJE: count={countAll}, avgSalary={avgSalary:F2}, minAge={minAge}, maxAge={maxAge}, totalSalary={totalSalary:F0}");



//ELEMENTY

/*
select *
from people
where city == "Kielce"
Limit 1
*/

var firstFromKielce = people.Where(p => p.City == "Kielce").First();
Console.WriteLine($"\nFirst (z Kielc): {firstFromKielce}");

/*
select *
from people
where city == "Poznan"
Limit 1
*/

try
{
    var firstFromPoznan = people.Where(p => p.City == "Poznan").First();
    Console.WriteLine($"\nFirst (z Poznan): {firstFromPoznan}");
}
catch (Exception)
{

}

/*
select *
from people
where city == "Poznan"
Limit 1
*/

var firstFromPoznanV2 = people.Where(p => p.City == "Poznan").FirstOrDefault();
if (firstFromPoznanV2 != null)
    Console.WriteLine($"\nFirst (z Poznan): {firstFromPoznanV2}");
else
{
    //nie ma na kolekcji
}

/*
select *
from people
where city == "Kielc"
order by id desc
Limit 1

*/

var lastFromKielce = people.Where(p => p.City == "Kielce").LastOrDefault();
if (lastFromKielce != null)
    Console.WriteLine($"\nLast (z Kielce): {lastFromKielce}");
else
{
    //nie ma na kolekcji
}


//SPRAWDZANIE WARUNKÓW

/*
    
*/

var anyFromKrakow = people.Any(p => p.City == "Kraków");
var allAdults = people.All(p => p.Age >= 18);

//KONWERSJE

/*
select FirstName
from people

*/

var listOfNames = people.Select(p => p.FirstName);
Print("Kolekcja imion", listOfNames);


/*
select FirstName, Age
from people

*/

IEnumerable<BoxFirstNameAndAge> listOfNameAndAge = people.Select(p => new BoxFirstNameAndAge() { FirstName = p.FirstName, Age = p.Age });
Print("Kolekcja imion i lat", listOfNameAndAge);

/*
select FirstName, Age, City
from people

*/

var listOfNameAndAgeAndCity = people.Select(p => new { FirstName = p.FirstName, Age = p.Age, Miasto = p.City });

Console.WriteLine($"\n=== Kolekcja imion, lat i miast ===");
foreach (var item in listOfNameAndAgeAndCity)
    Console.WriteLine($"{item.FirstName}, {item.Age} lat, {item.Miasto}");



/*
select FirstName
from people
where City="Kielce"
order by FirstName

*/

var peopleFromKielceOrderByFirstName = people .Where(p => p.City == "Kielce")
                                              .OrderBy(p => p.FirstName)
                                              .Select(p => p.FirstName);
Print("Kolekcja imion ", peopleFromKielceOrderByFirstName);


// OPERACJE NA ZBIORACH (SET OPERATIONS)

/*
 select distinct City
 from people
*/

var uniqueCities = people
    .Select(p => p.City)
    .Distinct();

Print("Unikalne miasta", uniqueCities);

var uniqueSkills = people
    .SelectMany(p => p.Skills)
    .Distinct();

Print("Unikalne umiejêtnoœci", uniqueSkills);


var kielceSkills = people
    .Where(p => p.City == "Kielce")
    .SelectMany(p => p.Skills);

var krakowSkills = people
    .Where(p => p.City == "Kraków")
    .SelectMany(p => p.Skills);

/*
List<string> lista = new List<string>();
foreach (var item in kielceSkills)
    lista.Add(item);
foreach (var item in krakowSkills)
    lista.Add(item);
*/

var unionSkills = kielceSkills.Union(krakowSkills);

Print("Umiejêtnoœci Kielce + Kraków (Union)", unionSkills);


var femaleSkills = people
    .Where(p => p.Gender == Gender.Female)
    .SelectMany(p => p.Skills);

var maleSkills = people
    .Where(p => p.Gender == Gender.Male)
    .SelectMany(p => p.Skills);

/*
List<string> lista = new List<string>();
foreach (var f in femaleSkills)
    foreach (var m in maleSkills)
        if (f==m)
        {
            lista.Add(m);
            break;
        }
*/

var commonSkills = femaleSkills.Intersect(maleSkills);

Print("Wspólne umiejêtnoœci kobiet i mê¿czyzn (Intersect)", commonSkills);

var warsawSkills = people
    .Where(p => p.City == "Warszawa")
    .SelectMany(p => p.Skills);

/*
List<string> lista = new List<string>();
foreach (var w in warsawSkills)
{
    bool isIn = false;
    foreach (var k in kielceSkills)
        if (k==w)
        {
            isIn = true;
            break;
        }
    if (!isIn)
        lista.Add(w);
}
*/

var onlyWarsawSkills = warsawSkills.Except(kielceSkills);

Print("Umiejêtnoœci tylko w Warszawie (Except)", onlyWarsawSkills);


// £¥CZENIE KOLEKCJI (JOIN)

/*
 SELECT p.FirstName, p.LastName, c.Region
 FROM people p
 INNER JOIN cities c ON p.City = c.City
*/

var peopleWithRegion = people.Join(
    cities,
    p => p.City,
    c => c.City,
    (p, c) =>
    {
        //return new { p.FirstName, p.LastName, c.Region};
        return new { p,c};
    }
).Select(x => new {x.p.FirstName, x.p.LastName, x.c.Region});

Console.WriteLine("\n=== Osoby z regionami (JOIN) ===");
foreach (var item in peopleWithRegion)
{
    Console.WriteLine($"{item.FirstName} {item.LastName} | {item.Region}");
}


// DEFERRED vs IMMEDIATE EXECUTION

var deferredQuery = people
    .Where(p => p.Age > 30)
    .OrderBy(p => p.FirstName)
    .Where(p => p.Salary > 300)
    .ToList();


people.Add(new Person
{
    Id = 9,
    FirstName = "Nowy",
    LastName = "Uczeñ",
    Age = 45,
    Gender = Gender.Male,
    City = "Kielce",
    Salary = 11000m,
    Skills = ["C#"]
});

Console.WriteLine("\n=== Deferred execution – wynik ===");
foreach (var person in deferredQuery)
{
    Console.WriteLine(person);
}










void Print<T>(string title, IEnumerable<T> data)
{
    Console.WriteLine($"\n=== {title} ===");
    foreach (var item in data)
        Console.WriteLine(item);
}

class  BoxFirstNameAndAge
{
    public string FirstName { get; init; } = default!;
    public int Age { get; init; }

    public override string ToString()
            => $"{FirstName}, {Age} lat";
}

