using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parašykite sumos funkciją su 3 parametrais, kuris gražina int tipo atsakymą.
            //Parašykite dalmens funkciją su 2 parametrais, kuris gražina double tipo  atsakymą.
            //Išsikvieskite abi funkcijas ir atsakymą išveskite į ekraną.
            Suma(2, 3, 4);
            Dalyba(4, 7);
        }

        static void Suma(int skaicius1, int skaicius2, int skaicius3) 
        {
            Console.WriteLine("{0} + {1} + {2} = {3}",skaicius1, skaicius2, skaicius3, skaicius1+skaicius2+skaicius3);
        }
        static void Dalyba(double skaicius1, double skaicius2) 
        {
            Console.WriteLine("{0}/{1} = {2}", skaicius1, skaicius2, skaicius1 / skaicius2);
        }
    }
}
