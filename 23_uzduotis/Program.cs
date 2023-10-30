using System;
using System.Linq;

namespace _23_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Susikurkite kintamąjį, kuris pasakytų kiek automobilis vidutiniškai sunaudoja degalų 100 – ui km. Susikurkite masyvą, kuriame saugotumėte skirtingose
            //kelionėse nuvažiuotų kilometrų rodmenis. Raskite:
            //trumpiausią kelionę;
            //ilgiausią kelionę;
            //kiek kuro sąnaudų sunaudojo automobilis(skaičiavimui reikės rasti visus  nuvažiuotus km).

            double vidutinesKuroSanaudos = 12;
            int[] nuvaziuotiKilometrai = { 20, 150, 75, 13, 5, 268, 9865, 66 };
            int min = nuvaziuotiKilometrai.Min();

            Console.WriteLine("Trumpiausia kelionė: " + " " + min);

            int max = nuvaziuotiKilometrai.Max();
            Console.WriteLine("Ilgiausia kelionė: " + " " + max);

            int sum = nuvaziuotiKilometrai.Sum();
            Console.WriteLine("Viso nuvažiuota kilometrų: " + " " + sum);
            double kuroSanaudos = (((vidutinesKuroSanaudos / 100) * sum));
            Console.WriteLine("Kuro sąnaudos: " + " " + kuroSanaudos);
        }
    }
}
