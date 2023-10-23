using System;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Liepkite įvesti skaičių.Jei skaičius lyginis, tuomet išveskite šį skaičių bei jo penktą laipsnį.
            //Jei skaičius nesidalina iš 4, tuomet liepkite įvesti antrąjį skaičių.Išveskite abiejų skaičių 
            //sumą ir sandaugą.

            Console.Write("Įveskite skaičių: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (skaicius % 2 ==0) 
            {
                double lyginisPenktuoju = Math.Pow(5, skaicius);
                Console.Write("Pakeltas penktuoju laipsniu: " + lyginisPenktuoju);
            }
            Console.WriteLine();
            if (skaicius % 4 !=0) 
            {
                Console.Write("Įveskite kitą skaičių: ");
                int skaicius2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("{0}+{1}={2}", skaicius, skaicius2, skaicius + skaicius2);

            //nepavyksta sugalvoti kaip įvykdyti sąlygas :(
            }

        }
    }
}
