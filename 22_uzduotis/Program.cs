using System;
using System.Linq;

namespace _22_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Susikurkite savaitės temperatūrų rodmenų masyvą.Raskite:
            //žemiausią temperatūrą;
            //didžiausią temperatūrą;
            //vidurkį;
            //Temperatūrų, esančių žemiau už vidurkį, kiekį;
            //Temperatūrų, esančių aukščiau už vidurkį, kiekį.

            int[] savaitesTemperaturos = { 20, 32, 15, 10, 25, -2, -10 };
            int min = savaitesTemperaturos[0];
            for (int i = 0; i < savaitesTemperaturos.Length; i++)
            {
                if (savaitesTemperaturos[i] < min)
                {
                    min = savaitesTemperaturos[i];
                }
            }
            Console.WriteLine(min);
            Console.WriteLine();

            int[] savaitesTemperaturos2 = { 20, 32, 15, 10, 25, -2, -10 };
            min = savaitesTemperaturos2.Min();
            Console.WriteLine("Mažiausia savaitės temperatūra: " + " " + min);

            int max = savaitesTemperaturos2.Max();
            Console.WriteLine("Didžiausia savaitės temperatūra: " + " " + max);

            double average = savaitesTemperaturos2.Average();
            Console.WriteLine("Vidutinė savaitės temepratūra: " + " " + average);

            int count = savaitesTemperaturos2.Count();
            for (int i = 0; i < savaitesTemperaturos2.Length; i++)
            {
                if (savaitesTemperaturos2[i] < average)
                {
                    count = savaitesTemperaturos2[i];                    // Nesugalvoju kaip uzbaigti if'ą, kad išpildytu sąlygą.                                            
                }
            }
            Console.WriteLine("Temperatūrų, esančių žemiau už vidurkį, kiekis: " + count);

            //Susikurkite studentų pažymių masyvą. Raskite:
            //geriausią pažymį;
            //kiek mokinių yra gavę dešimtukus;
            //kiek mokinių yra gavę neigiamą pažymį(žemiau nei 4);
            //pažymių vidurkį.

            int[] pazymiai = { 5, 4, 3, 2, 10, 9, 8, 7, 6 };
            int maxPazymiai = pazymiai.Max();
            Console.WriteLine("Geriausias pažimys: " + " " + pazymiai.Max());
            int countPazymiai = pazymiai.Count();
            for (int i = 0; i < pazymiai.Length; i++)
            {
                if (pazymiai[i] == 10)
                {
                    count = pazymiai[i];                                // Nesugalvoju kaip uzbaigti if'ą, kad išpildytu sąlygą.
                }
                Console.WriteLine("Tiek mokinių gavo 10: " + " " + count);
            }

        }
    }
}
