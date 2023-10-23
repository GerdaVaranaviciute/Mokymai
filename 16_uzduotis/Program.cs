using System;
using System.Diagnostics.CodeAnalysis;

namespace _16_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Raskite visų skaičių nuo 1 iki 100 sumą.

            int sum = 0;
            for (int i = 1; i <= 100; i++ ) 
            {
                sum += i;
            }
            Console.WriteLine("Skaičių nuo 1 iki 100 suma: " + sum);

            //Raskite visų lyginių skaičių nuo 20 iki 40 sumą.

            for (int i = 20; i <= 40; i++ ) 
            {
                sum += i;
            }
            Console.WriteLine("Skaičių nuo 20 iki 40 suma: " + sum);

            

        }
    }
}
