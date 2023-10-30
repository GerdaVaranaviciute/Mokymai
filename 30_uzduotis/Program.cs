using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Leiskite vartotojui įvesti du sveikuosius skaičius į programą.  Sukurkite 
            //ir panaudokite šiuos metodus:
            //Suma;
            //Skirtumas;
            //Sandauga;
            //Dalmuo;

            Console.WriteLine("Įveskite skaičių: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antrąjį skaičių: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            Suma(skaicius, skaicius2);
            Skirtumas(skaicius, skaicius2);
            Sandauga(skaicius, skaicius2);
            Dalyba(skaicius, skaicius2);    
        }

        static void Suma(int skaicius, int skaicius2)
        {
            Console.WriteLine("{0} + {1} = {2}", skaicius, skaicius2, skaicius + skaicius2);
        }

        static void Skirtumas(int skaicius, int skaicius2)
        {
            Console.WriteLine("{0} - {1} = {2}", skaicius, skaicius2, skaicius - skaicius2);
        }

        static void Sandauga(int skaicius, int skaicius2)
        {
            Console.WriteLine("{0} * {1} = {2}", skaicius, skaicius2, skaicius * skaicius2);
        }
       
        static void Dalyba(int skaicius, int skaicius2) 
        {
            Console.WriteLine("{0} / {1} = {2}", skaicius, skaicius2, skaicius / skaicius2);
        }
    }
}
