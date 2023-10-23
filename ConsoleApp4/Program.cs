using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti tris skaičius, parašyti šią patikrinimo sąlygą, 
            //naudojant else if dalis:
            //ar pirmas skaičius didesnis už antrą;
            //ar antras skaičius didesnis už trečią;
            //ar trečias skaičius didesnis už pirmą;
            //ar pirmi du skaičiai lygūs;

            Console.WriteLine("Įveskite pirmąjį skaičių: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antrąjį skaičių: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite trečiajį skaičių: ");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (skaicius1 > skaicius2)
            {
                Console.WriteLine("Skaičius" + " " + skaicius1 + " didesnis už skaičių" + " " + skaicius2);
            }
            else if (skaicius2 > skaicius3)
            {
                Console.WriteLine("Skaičius" + " " + skaicius2 + " didesnis už skaičių" + " " + skaicius3);
            }
            else if (skaicius3 > skaicius1)
            {
                Console.WriteLine("Skaičius" + " " + skaicius3 + " didesnis už skaičių" + " " + skaicius1);
            }
            else if (skaicius1 == skaicius2)
            {
                Console.WriteLine("Skaičius" + " " + skaicius1 + " lygus" + " " + skaicius2);
            }


            //Liepkite vartotojui įvesti šios dienos oro temperatūrą, atlikite šiuos patikrinimus:
            //ar temperatūra< 0 - išvesti “žiauriai šalta”;
            //ar temperatūra< 10 - išvesti “labai šalta”;
            //ar temperatūra< 20 - išvesti “šalta”;
            //ar temperatūra< 30 - išvesti “normali temperatūra”;
            //ar temperatūra< 40 - išvesti “karšta”;
            //ar temperatūra >= 40 - išvesti “visiškai degina”;

            Console.Write("Suveskite šios dienos oro temperatūrą: ");
            int oroTemperatura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (oroTemperatura < 0)
            {
                Console.WriteLine("Žiauriai šalta");
            }
            else if (oroTemperatura < 10)
            {
                Console.WriteLine("Labai šalta");
            }
            else if (oroTemperatura < 20) 
            {
                Console.WriteLine("Šalta");
            }
            else if (oroTemperatura < 30)
            {
                Console.WriteLine("Normali temperatūra");
            }
            else if (oroTemperatura < 40) 
            {
                Console.WriteLine("Karšta");
            }
            else if (oroTemperatura >= 40) 
            {
                Console.WriteLine("Visiškai degina");
            }
        }
    }
}
