using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parašykite metodą, kuris pasisveikintų su vartotoju.
            //Vartotojas turi įvesti savo vardą, amžių ir hobio pavadinimą.
            //Visi šie duomenys yra duodami metodui, kuris visą šią informaciją išveda
            //formatuotai

            Console.WriteLine("Įveskite savo vardą: ");
            string vardas = Console.ReadLine();

            Console.WriteLine("Įveskite kiek jums metų: ");
            int metai = Convert.ToInt32(Console.ReadLine());

            Pasisveikinimas(vardas, metai);
        }

        static void Pasisveikinimas(string vardas, int metai)
        {
            Console.WriteLine($"Labas {vardas} ({metai} m.)");
        }
    }
}
