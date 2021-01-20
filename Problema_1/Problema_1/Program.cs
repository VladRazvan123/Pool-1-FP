using System;

namespace Problema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 

            Console.WriteLine("Introduceti 2 numere.");


            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            float x;

            if (a != 0)
            {
                x = -(float)b / (float)a;
                Console.WriteLine($"X-ul este {x}");
            }
            else
            {
                if (b == 0)
                {
                    Console.WriteLine("Avem o infinitate de solutii.");
                }
                else
                {
                    Console.WriteLine("Nu exista o solutie.");
                }
            }
        }
    }
}
