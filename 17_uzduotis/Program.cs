using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti teigiamą skaičių.Ciklo pagalba šį skaičių išvesti mažėjimo tvarka iki kol jis pasieks 0.
            //Pvz.: 5 4 3 2 1.Kiekvieną kartą išvesti skirtingose eilutėse.

            Console.WriteLine("Įveskite teigiamą skaičių: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            while (skaicius > 0)
            {
                Console.WriteLine(skaicius);
                skaicius--;
            }

            //Liepkite vartotojui įvesti neigiamą skaičių. Ciklo pagalba šį skaičių išvesti didėjimo tvarka iki kol jis pasieks 0, taip pat išvesti 0.
            //Pvz.: -4 -3 -2 -1 0. Kiekvieną kartą išvesti toje pačioje eilutėje, skaičius atskiriant tarpais.

            Console.WriteLine("Įveskite neigiamą skaičių: ");
            int skaiciusNeigiamas = Convert.ToInt32(Console.ReadLine());
            while (skaiciusNeigiamas < 0)
            {
                Console.WriteLine(skaiciusNeigiamas);
                skaiciusNeigiamas++;
            }

            //Padarykite skaičiuotuvą. Kiekvieno ciklo iteracijos metu vartotojas turi suvesti du skaičius.Iš šių skaičių turi būti grąžinami visi sudėties, 
            //skirtumo, sandaugos ir dalmens atsakymai, išvedant kartu ir atliekamus veiksmus.Pvz.:
            //5 + 4 = 9
            //5 - 4 = 1
            //Programa vykdoma tol, kol vartotojas nori atlikinėti skaičiavimus.

            Console.WriteLine("Įveskite du skaičius");
            Console.WriteLine("Įveskite pirmąjį skaičių: ");
            int pirmasSkaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antąjį skaičių: ");
            int antrasSkaicius = Convert.ToInt32(Console.ReadLine());   

            //dar nesugalvojau kaip parašyti
            while () 
            {
                
            }

        }
    }
}
