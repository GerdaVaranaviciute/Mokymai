using System;
using System.Net.NetworkInformation;

namespace _13_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti tris skaičius.Su switch patikrinkite pirmąjį skaičių:
            //ar jis lygus 1: išveskite visų trijų skaičių sumą;
            //ar jis lygus 2: išveskite pirmo ir trečio skaičių skirtumą;
            //ar jis lygus 3: išveskite antro ir trečio skaičių sandaugą.

            Console.WriteLine("Įveskite pirmąjį skaičių: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antrąjį skaičių: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite trečiajį skaičių: ");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());
            switch (skaicius1)
            {
                case 1:
                    Console.WriteLine("Vienas");
                    Console.WriteLine("{0} + {1} + {3} = {4}", skaicius1, skaicius2, skaicius3, skaicius1 + skaicius2 + skaicius3);
                    break;
                case 2:
                    Console.WriteLine("Du");
                    Console.WriteLine("{0} - {1} = {2}", skaicius1, skaicius3, skaicius1 - skaicius3);
                    break;
                case 3:
                    Console.WriteLine("Trys");
                    Console.WriteLine("{0} * {1} = {2}", skaicius2, skaicius3, skaicius2 * skaicius3);
                    break;
            }

            //Nesugalvoju kodėl nepavyksta išvesti uždavinių

            //Liepkite vartotojui įvesti gyvūno rūšį.Su switch patikrinkite:
            //ar įvestas gyvūnas yra šuo;
            //ar įvestas gyvūnas yra katė;
            //ar įvestas gyvūnas yra žiurkėnas.

            Console.WriteLine("Įveskiti gyvūno rūšį: ");
            string gyvunas = Console.ReadLine();

            switch (gyvunas) 
            {
                case "Šuo":
                    Console.WriteLine("Šuo");
                    break;
                case "Katė":
                    Console.WriteLine("Katė");
                    break;
                case "Žiurkėnas":
                    Console.WriteLine("Žiurkėnas");
                    break;
                default:
                    Console.WriteLine("Neatpažintas gyvūnas");
                    break;
            }

        }
    }
}
