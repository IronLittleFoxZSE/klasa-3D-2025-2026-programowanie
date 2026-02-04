using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsoleApp
{
    internal class Podstawa
    {
        public void Test()
        {
            List<int> numbers = [1, 9, 4, 6, 8, 15];

            Console.WriteLine("Ca³a kolekcja");
            foreach (int num in numbers)
            {
                Console.Write($"{num}, ");
            }
            Console.WriteLine();


            List<int> evenNum /*= new List<int>()*/;
            /*foreach (int num in numbers)
            {
                if (num % 2 == 0)
                    evenNum.Add(num);
            }*/
            //evenNum = Where(numbers);
            evenNum = Where(numbers, n => n % 2 == 0);

            Console.WriteLine("Ca³a liczb parzystych:");
            foreach (int num in evenNum)
            {
                Console.Write($"{num}, ");
            }
            Console.WriteLine();

            //List<int> yearNumber = WhereYear(numbers);
            List<int> yearNumber = Where(numbers, n => n % 4 == 0 && n % 100 != 0 || n % 400 == 0);

            Console.WriteLine("Kolekcja lat przestêpnych:");
            foreach (int num in yearNumber)
            {
                Console.Write($"{num}, ");
            }
            Console.WriteLine();

            List<string> texts = ["Ala", "Ola", "Ilona"];
            List<string> otherText = Where(texts, s => s.Length == 3 && s.StartsWith("O"));

            /*
            List<int> Where(List<int> collection)
            {
                List<int> result = new List<int>();
                foreach (int num in collection)
                {
                    if (num % 2 == 0)
                        result.Add(num);
                }
                return result;
            }

            List<int> WhereYear(List<int> collection)
            {
                List<int> result = new List<int>();
                foreach (int num in collection)
                {
                    if (num % 4 == 0 && num % 100 != 0 || num % 400 == 0)
                        result.Add(num);
                }
                return result;
            }
            */
            /*List<int> Where(List<int> collection, Func<int, bool> spr )
            {
                List<int> result = new List<int>();
                foreach (int num in collection)
                {
                    if (spr(num))
                        result.Add(num);
                }
                return result;
            }*/

            List<T> Where<T>(List<T> collection, Func<T, bool> spr)
            {
                List<T> result = new List<T>();
                foreach (T num in collection)
                {
                    if (spr(num))
                        result.Add(num);
                }
                return result;
            }
        }
    }
}
