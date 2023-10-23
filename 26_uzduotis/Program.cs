using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Sugeneruokite atsitiktinio dydžio sąrašą, kurį užpildykite atsitiktiniais  skaičiais nuo 1 iki 100.Raskite:
            //mažiausią skaičių;
            //didžiausią skaičių;
            //vidurkį;
            //kiek skaičių yra žemesni už vidurkį;
            //lyginių skaičių sumą;

            List<int> skaiciai = new List<int>();
            skaiciai.Add(15);
            skaiciai.Add(25);
            skaiciai.Add(42);
            skaiciai.Add(55);
            skaiciai.Add(98);

            int min = skaiciai.Min();
            Console.WriteLine("Mažiausias skaičius: " + " " + min);
            int max = skaiciai.Max();
            Console.WriteLine("Didžiausias skaičius: " + " " + max);
            double average = skaiciai.Average();
            Console.WriteLine("Vidurkis: " + " " + average);

            int zemiauUzVidurki = 0;
            foreach (int i in skaiciai)
            {
                if (i < average) 
                { 
                    zemiauUzVidurki++;
                }
            }
            Console.WriteLine("Kiek skaičių žemesnių už vidurkį: " + zemiauUzVidurki);

            int lyginiuSkaiciuSuma = 0;
            foreach (int i in skaiciai) 
            {
                if (i % 2 ==0 ) 
                {
                    lyginiuSkaiciuSuma += i;
                }

            }
            Console.WriteLine("Lyginiu skaičių suma: " + lyginiuSkaiciuSuma);


            //Liepkite vartotojui pasirinkti kiek studentų pažymių nori suvesti į sąrašą.  Tegul jis užpildo šį sąrašą duomenimis, įvedant juos per konsolę.Raskite:
            //didžiausią pažymį;
            //mažiausią pažymį;
            //vidurkį;

        }
    }
}
