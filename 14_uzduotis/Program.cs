using System;
using System.Web;

namespace _14_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Į ekraną išveskite kelis sunumeruotus pasirinkimus
            //1 - stacionarus kompiuteris
            //2 - nešiojamas kompiuteris
            //3 - planšetė
            //Liepkite vartotojui įvesti pasirinkimo numerį.
            //Pagal įvestą numerį išveskite atitinkamą tekstą. Pvz:
            //nešiojamuoju kompiuteriu galite naudotis visur
            //stacionariu kompiuteriu galite naudotis tik namuose arba darbo vietoje
            //planšete galite naudotis visur
            //Neradus tinkamo varianto išvesti, kad tokio pasirinkimo nėra.

            
            Console.WriteLine("Pasirinkite vieną iš žemiau pateiktų variantų: \n1 - stacionarus komiuteris \n2 - nešiojamas kompiuteris \n3 - planšetė \nJūsų atsakymas: ");
            int atsakymas = Convert.ToInt32(Console.ReadLine());
            if (atsakymas == 1 ) 
            {
                Console.WriteLine("Stacionariu kompiuteriu galite naudotis tik namuose arba darbo vietoje");
            }
            else if (atsakymas == 2 ) 
            {
                Console.WriteLine("Nešiojamuoju kompiuteriu galite naudotis visur");
            }
            else if (atsakymas == 3 ) 
            {
                Console.WriteLine("Planšete galite naudotis visur");
            }
            else if (atsakymas != 1 && atsakymas != 2 && atsakymas != 3) 
            {
                Console.WriteLine("Tokio pasirinkimo nėra");            
            }
        }
    }
}
