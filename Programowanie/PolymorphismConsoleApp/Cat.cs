using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismConsoleApp
{
    class Animal
    {

    }

    class Dog : Animal
    {

    }

    internal class Cat : Animal, IWorkOnFiles
    {
        string name;

        public Cat(string n)
        {
            name = n;
        }

        public void Meow()
        {
            Console.WriteLine("Kot miałczy");
        }

        public virtual void SaveToFile()
        {
            //zapis do pliku
        }
    }
}
