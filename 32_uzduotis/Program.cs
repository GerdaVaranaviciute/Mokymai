﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Paprašyti įvesti vartotojo vardą.
            //Sukurti string tipo metodą, kuris gražina frazę pvz „Sveiki, Mantas“.
            //Išvesti šią frazę į konsolę.

            Console.WriteLine("Įveskite savo vardą: ");
            string vardas = Console.ReadLine();
            Pasisveikinimas(vardas);

        }
        static void Pasisveikinimas(string vardas) 
        {
            Console.WriteLine($"Sveiki, {vardas}!");
        }

    }
}
