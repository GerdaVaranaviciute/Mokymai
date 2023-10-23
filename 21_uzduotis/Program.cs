using System;
using System.Linq;

namespace _21_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Susikurti 2 masyvus su duomenimis, išbandant abu kūrimo būdus(iškart su  duomenimis, arba pirma nusirodant dydį ir tada priskiriant reikšmes),
            //pasibandymui išsivesti norimus duomenis iš visų šių masyvų:
            //skirtą studentų pažymiams saugoti;
            //skirtą mašinų markėms saugoti.

            int [] pazymiai = { 8, 9, 5, 4, 6, 10, 10, 10, 9, 4, 2, 2, 4 };
            Console.WriteLine(pazymiai[3]);
            Console.WriteLine(pazymiai[12]);
            Console.WriteLine(pazymiai[0]);
            Console.WriteLine(pazymiai[9]);
            Console.WriteLine();
            Console.WriteLine(pazymiai.Length);
            Console.WriteLine("Pirmas pažimys: " + pazymiai.First());
            Console.WriteLine("Paskutinis pažimys: " + pazymiai.Last());
            Console.WriteLine("Paskutinis pažimys: " + pazymiai[pazymiai.Length - 1]);
            Console.WriteLine();

            int[] pazymiai2 = new int[5];
            pazymiai2[0] = 9;
            pazymiai2[1] = 5;
            pazymiai2[2] = 4;
            pazymiai2[3] = 6;
            pazymiai2[4] = 6;
            Console.WriteLine("Pažimys" + " " + pazymiai2[0]);
            Console.WriteLine();   

            string[] automobiliuMarkes = { "Audi", "BMW", "Toyota", "Saab", "MiniCooper" };
            Console.WriteLine(automobiliuMarkes[0]);
            Console.WriteLine(automobiliuMarkes[4]);
            Console.WriteLine(automobiliuMarkes[3]);
            Console.WriteLine();
            Console.WriteLine(automobiliuMarkes.Length);
            Console.WriteLine("Pirma reikšmė: " + automobiliuMarkes.First());
            Console.WriteLine("Paskutinė reikšmė: " + automobiliuMarkes.Last());
            Console.WriteLine("Paskutinė reikšmė: " + automobiliuMarkes[automobiliuMarkes.Length - 1]);

            string[] automobiliuMarkes2 = new string[5];
            automobiliuMarkes2[0] = "Audi";
            automobiliuMarkes2[1] = "BMW";
            automobiliuMarkes2[2] = "Toyota";
            automobiliuMarkes2[3] = "Saab";
            automobiliuMarkes2[4] = "MiniCooper";
            Console.WriteLine("Automobilio marke:" + " " + automobiliuMarkes2[3]);
        }
    }
}
