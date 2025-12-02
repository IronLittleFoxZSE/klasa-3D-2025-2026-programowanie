using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismConsoleApp
{
    internal class Triangle: Figure
    {
        protected int sideA, sideB, sideC;
        protected int height;

        public Triangle(int a, int b, int c, int h)
        {
            sideA = a;
            sideB = b;
            sideC = c;
            height = h;
            name = "trójkąt";
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Obiekt {name}:");
            Console.WriteLine($"Bok a = {sideA}");
            Console.WriteLine($"Bok b = {sideB}");
            Console.WriteLine($"Bok c = {sideC}");
            Console.WriteLine($"Wysokość = {height}");
            Console.WriteLine($"Obwód = {GetPerimeter()}");
            Console.WriteLine($"Pole = {GetArea()}");
            Console.WriteLine();
        }

        public override int GetPerimeter()
        {
            return sideA + sideB + sideC;
        }

        public override int GetArea()
        {
            return sideB * height / 2;
        }

        public override void SaveToFile()
        {
            //zapis do pliku
        }
    }
}

/*
 
                /\
           a   /  \  c
              /    \
              ------
                b
*/