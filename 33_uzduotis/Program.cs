using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Įvesti du skaičius iš konsolės
            //Paklausti vartotojo kokį veiksmą su tais skaičiais nori atlikti: 
            //sudėtis, atimtis,  kėlimas 4 laipsniu sudėjus abu skaičius, kvadratinė 
            //šaknis sudėjus abu skaičius.
            //Parašyti po atskirą metodą kiekvienam veiksmui(sudėčiai ir atimčiai
            //naudoti  int tipą, o visiems kitiems double).
            //Su switch () patikrinti kokį veiksmą atlikti ir kiekviename case‘e 
            //išsikviesti  atitinkamą metodą, jei tokio case‘o nėra – informuoti vartotoją
            //, jog tokio veiksmo nėra.

            Console.WriteLine("Įveskite pirmąjį skaičių: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antąjį skaičių: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kokį veiksmą atlikti(Sudėtis, Atimtis, Suma ketvirtuoju, Sumos kvadratinė šaknis: ");
            string veiksmas = Console.ReadLine();

            switch (veiksmas)
            {
                case "Sudėtis":
                    Sudetis(skaicius1, skaicius2);
                    break;
                case "Atimtis":
                    Atimtis(skaicius1, skaicius2);
                    break;
                case "Suma ketvirtuoju":
                    SumosKelimasKetvirtuLaipsniu(skaicius1, skaicius2);
                    break;
                case "Sumos kvadratinė šaknis":
                    SumosKvadratineSaknis(skaicius1, skaicius2);
                    break;
                default: Console.WriteLine("Tokio veiksmo nėra.");
                    break;
            }
        }
        static void Sudetis (int skaicius1, int skaicius2) 
        {
            Console.WriteLine("{0} + {1} = {2}", skaicius1, skaicius2,skaicius1 + skaicius2);
        }
        static void Atimtis (int skaicius1, int skaicius2) 
        {
            Console.WriteLine("{0} - {1} = {2}", skaicius1, skaicius2, skaicius1 - skaicius2);
        }
        static void SumosKelimasKetvirtuLaipsniu(double skaicius1, double skaicius2) 
        {
            double suma = skaicius1 + skaicius2;
            double sumaKetvrituoju = Math.Pow(suma, 4);
            Console.WriteLine("({0} + {1})^4 = {2}", skaicius1, skaicius2, sumaKetvrituoju);
        }
        static void SumosKvadratineSaknis(double skaicius1, double skaicius2) 
        {
            double suma = skaicius1 + skaicius2;
            double sumosKvadratas = Math.Sqrt(suma);
            Console.WriteLine("sqrt({0} + {1})= {2}", skaicius1, skaicius2, sumosKvadratas);
        }

        }
}
