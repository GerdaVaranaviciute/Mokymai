using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sukurti klasę Mokinys su kintamaisiais: vardas, pavardė, amžius, klasė ir  
            //pažymių sąrašą, kur saugosime 5 pažymius.
            //Sukurti konstruktorių, kad priskirtų reikšmes.
            //Klasės viduje sukurti metodą, kad išvestų visą informaciją apie mokinį.
            //Susikurti 3 objektus, jiems priskirti reikšmes ir naudojant sukurtą metodą 
            //išvesti kiekvieno mokinio informaciją.

            Mokinys MokinysJonas= new Mokinys("Jonas", "Jonaitis", 13, 6);
            MokinysJonas.MokinioPristatymas();
            Mokinys MokinysPetras = new Mokinys("Petras", "Petraitis", 16, 10);
            MokinysPetras.MokinioPristatymas();
            Mokinys MokinysTadas = new Mokinys("Tadas", "Tadauskas", 7, 2);
            MokinysTadas.MokinioPristatymas();
        }
    }
}
