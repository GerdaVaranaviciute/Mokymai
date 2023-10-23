using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti savo vardą ir amžių.
            //Į ekraną išveskite: “Jūsų vardas { vardas}, o amžius { amžius}.”

            Console.Write("Įveskite savo vardą:");
            string vardas = Console.ReadLine();
            Console.Write("Įveskite savo amžių:");
            string amzius = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Jūsų vardas" + " " + vardas + " , o jūsų amžius" + " " + amzius);
            Console.WriteLine();

            //Liepkite vartotojui įvesti bet kokį simbolį. Atspausdinkite 3x3 kvadratą iš to
            //simbolio.

            Console.WriteLine();
            Console.Write("įveskite betkokį simbolį:");
            string simbolis = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(simbolis + simbolis + simbolis);
            Console.WriteLine(simbolis + simbolis + simbolis);
            Console.WriteLine(simbolis + simbolis + simbolis);
            Console.WriteLine();

            //Liepkite vartotojui įvesti bet kokį skaičių. Išveskite į ekraną šio
            //skaičiaus kvadratą.

            Console.WriteLine();
            Console.Write("Įveskite skaičių:");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            Console.Write(skaicius);
            Console.Write(skaicius);
            Console.Write(skaicius);
            Console.WriteLine();
            Console.Write(skaicius);
            Console.Write(skaicius);
            Console.Write(skaicius);
            Console.WriteLine();
            Console.Write(skaicius);
            Console.Write(skaicius);
            Console.Write(skaicius);
            Console.WriteLine();

            //Liepkite vartotojui įvesti tris skaičius.Išveskite visų šių skaičių sumą
            //nurodant atliekamus veiksmus ir šių skaičių reikšmes ekrane. Pvz.: 5 + 3 + 8 = 16

            Console.WriteLine();
            Console.Write("Įveskite pirmąjį skaičių:");
            int sveikasSkaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite antrąjį skaičių:");
            int sveikasSkaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite trečiajį skaičių:");
            int sveikasSkaicius3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0} + {1} + {2} = {3}", sveikasSkaicius1, sveikasSkaicius2,sveikasSkaicius3, sveikasSkaicius1 + sveikasSkaicius2 + sveikasSkaicius3);
            Console.WriteLine();
        }
    }
}
