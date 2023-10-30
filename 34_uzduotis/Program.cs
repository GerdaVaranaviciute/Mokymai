using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Įvesti du skaičius iš konsolės
            //Paklausti vartotojo kokį veiksmą su tais skaičiais nori atlikti: 
            //Daugybą ar  dalybą
            //Parašyti po atskirą metodą kiekvienam veiksmui(daugybai naudoti int tipą, 
            //o  dalybai double)
            //Su if patikrinti kokį veiksmą atlikti ir išsikviesti atitinkamą metodą, 
            //jei tokio  veiksmo nėra – informuoti vartotoją, jog tokio veiksmo nėra.

            int skaicius1 = 2;
            int skaicius2 = 10;

            Console.WriteLine("Kokį veiksmą norite atlikti su skaičiais 2 ir 10?");
            string atsakymas = Console.ReadLine();

            if (atsakymas == "Daugyba")

            {
                Daugyba(skaicius1, skaicius2);
            }
            else if (atsakymas == "Dalyba")
            {
                Dalyba(skaicius1, skaicius2);
            }
            else
                Console.WriteLine("Tokio veiksmo nėra");
        }

        static void Daugyba (int skaicius1, int skaicius2) 
        {
            Console.WriteLine("{0} * {1} = {2}", skaicius1, skaicius2, skaicius1 + skaicius2);
        }
        static void Dalyba (double skaicius1, double skaicius2) 
        {
            Console.WriteLine("{0} / {1} = {2}", skaicius1, skaicius2, skaicius1 / skaicius2);
        }
    }
}
