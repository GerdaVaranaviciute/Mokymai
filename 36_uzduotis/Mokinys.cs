using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _36_uzduotis
{
    internal class Mokinys
    {
        internal string vardas;
        internal string pavarde;
        internal int metai;
        internal int klase;
        internal List<int> pazymiai;

        public Mokinys(string vardas, string pavarde, int metai, int klase) //List<int> pazymiai)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.metai = metai;
            this.klase = klase;
            this.pazymiai = pazymiai;
        }

        public void MokinioPristatymas() 
        {
            Console.WriteLine($"Mokinio vardas yra {vardas}, pavarde {pavarde}, jam yra {metai} metų ir jis mokosi {klase} klasėje.");
        }
    }
}
