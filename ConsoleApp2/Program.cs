using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti savo amžių.Jei amžius yra 18 arba daugiau,
            //tuomet į ekraną išveskite, kad “jūs galite balsuoti”.

            Console.Write("Įveskite savo amžių: ");
            int amzius = Convert.ToInt32(Console.ReadLine());
            if (amzius >= 18)
            {
                Console.Write("Jūs galite balsuoti");
            }
            Console.WriteLine();

            //Liepkite vartotojui įvesti bet kokį skaičių. Parašykite šias atskiras if sąlygas:
            //Patikrinti, ar skaičius neigiamas, jei taip -aprėkti vartotoją:)
            //Patikrinti, ar skaičius teigiamas, jei taip -pasveikinti vartotoją;
            //Patikrinti, ar skaičius lyginis, jei taip -išvesti “taip, skaičius yra lyginis”;
            //Patikrinti, ar skaičius dalinasi iš 4, jei taip -išvesti “taip, dalinasi iš 4”;
            //Patikrinti, ar skaičius yra didesnis nei 10, jei taip -išvesti “taip, skaičius 
            //yra didesnis už 10”.

            Console.Write("Įveskite skaičių: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            if (skaicius < 0)
            {
                Console.Write("Nedrįskite rašyti neigiamų skaičių!!!!");
            }
            Console.WriteLine();
            if (skaicius > 0)
            {
                Console.Write("Nuostabu!Parašėte puikų skaičių!");
            }
            Console.WriteLine();
            if (skaicius % 2 == 0)
            {
                Console.Write("Taip,skaičius yra lyginis");
            }
            Console.WriteLine();
            if (skaicius % 4 == 0)
            {
                Console.Write("Taip, skaičius dalinasi iš 4");
            }
            Console.WriteLine();
            if (skaicius > 10)
            {
                Console.Write("Taip, skaičius didesnis už 10");
            }
            Console.WriteLine();


            //Liepkite vartotojui įvesti du savo pažymius, raskite 
            //šių pažymių vidurkį, patikrinkite, ar vidurkis yra lygus arba 
            //didesnis už 5, jei taip, išveskite “Valio!!!”.

            Console.Write("Įveskite pirmąjį pažymį: ");
            int pazimys1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite antrąjį pažymį: ");
            int pazimys2 = Convert.ToInt32(Console.ReadLine());
            Console.Write((double)(pazimys1 + pazimys2) / 2);
            Console.WriteLine();
            if (((double)(pazimys1 + pazimys2) / 2) > 5) 
            {
                Console.Write("Valio!!!");
            }
            Console.WriteLine();

        }
    }
}
