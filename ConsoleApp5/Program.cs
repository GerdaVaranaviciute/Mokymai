using System;


namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Liepkite įvesti tris skirtingus skaičius.Suraskite, kuris iš šių skaičių yra didžiausias.

            Console.WriteLine("Įveskite skaičių: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antrąjį skaičių: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite trečiajį skaičių: ");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());

            if (skaicius1 > skaicius2 && skaicius1 > skaicius3)
            {
                Console.Write("Didžiausias skaičius: " + skaicius1);
            }
            else if (skaicius2 > skaicius1 && skaicius2 > skaicius3)
            {
                Console.Write("Didžiausias skaičius: " + skaicius2);
            }
            else if (skaicius3 > skaicius2 && skaicius3 > skaicius1)
            {
                Console.Write("Didžiausias skaičius: " + skaicius3);
            }

            //Liepkite įvesti egzamino rezultatą. Atlikite šiuos patikrinimus:
            //ar gautas rezultatas yra[8 - 10];
            //ar gautas rezultatas yra[5 - 8);
            //ar gautas rezultatas yra< 5.

            Console.WriteLine("Įveskite egzamino rezultatą: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());

            if (skaicius >= 8 && skaicius <= 10) 
            {
                Console.WriteLine("Gautas rezultatas tarp 8 ir 10");
            }
            else if (skaicius >= 5 && skaicius <= 8) 
            {
                Console.WriteLine("Gautas rezultatas tarp 5 ir 8");
            }
            else if (skaicius <5) 
            {
                Console.WriteLine("Gautas rezultatas mažiau už 5");
            }

            //Liepkite įvesti du skaičius. Patikrinkite(naudojant 4 atskirus if’us):
            //ar pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0;
            //ar antras skaičius yra didesnis už pirmąjį, arba yra lygus 5;
            //ar pirmas skaičius yra didesnis už antrąjį ir yra lygus 20;
            //ar antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100.

            Console.WriteLine("Įveskite skaičių: ");
            int skai1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antrąjį skaičių: ");
            int skai2 = Convert.ToInt32(Console.ReadLine());

            if (skai1 > skai2 || skai1 == 0) 
            {
                Console.WriteLine("Pirmasis kaičius didesnis už antrąjį arba lygus 0");
            }
            else if (skai2>skai1 || skai2 == 0) 
            {
                Console.WriteLine("Antras skaičius yra didesnis už pirmąjį arba lygus 5");
            }
            else if (skai1 > skai2 && skai1 == 20) 
            {
                Console.WriteLine("Pirmas skaičius yra didesnis už antąjį ir lygus 20");
            }
            else if ( skai2 > skai1 && skai2 < 100) 
            {
                Console.WriteLine("Antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100");
            }


        }

    }
}
