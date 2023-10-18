using System;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parašykite programą, kuri išvestų žodį
            //“Labas” ir jūsų vardą toje pačioje eilutėje.

            Console.WriteLine("Labas, Gerda!");
            Console.WriteLine(" ");

            //Susikurkite kintamąjį žmogaus amžiui nusakyti, išveskite
            //į ekraną tekstą su
            //šiuo amžiumi: “Įvestas amžius: { amžius}”. Tarp { }
            //nurodytas kintamasis, kurio
            //reikšmė toje vietoje turi būti įstatyta.

            Console.WriteLine(" ");
            int amzius = 29;
            Console.WriteLine("Įvestas amžius:" + amzius);
            Console.WriteLine(" ");

            //Susikurkite skaičiaus kintamąjį, kurį išveskite penkis
            //kartus toje pačioje eilutėje be tarpų tarp šių skaičių
            //(skaičius -25, išvedimas - 2525252525).

            int skaicius = 25;
            for (int i = 0; i < 5; i++)
            {
                Console.Write(skaicius);
            }
            Console.WriteLine(" ");

            //Susikurkite skaičiaus kintamąjį, kurį išveskite penkis kartus toje pačioje
            //eilutėje su tarpais tarp šių skaičių(skaičius - 25, rezultatas - 25 25 25 25 25).

            Console.WriteLine(" ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(skaicius + " ");
            }
            Console.WriteLine(" ");

            //Uzduotis kvadratas - iš kažkur atsiranda du papildomi simboliai "|", nesurandu kur;

            Console.WriteLine(" ");
            string virsusApacia = "_";
            string kaireSiena = "|";
            string desineSiena = "|";
            for (int i = 0; i < 20; i++)
            Console.Write(virsusApacia);
            Console.WriteLine(kaireSiena + "                  " + desineSiena);
            Console.WriteLine(kaireSiena + "                  " + desineSiena);
            Console.WriteLine(kaireSiena + "                  " + desineSiena);
            Console.WriteLine(kaireSiena + "                  " + desineSiena);
            Console.WriteLine(kaireSiena + "   Mano vardas    " + desineSiena);
            Console.WriteLine(kaireSiena + "      Gerda       " + desineSiena);
            Console.WriteLine(kaireSiena + "                  " + desineSiena);
            Console.WriteLine(kaireSiena + "                  " + desineSiena);
            Console.WriteLine(kaireSiena + "                  " + desineSiena);
            Console.WriteLine(kaireSiena + "                  " + desineSiena);
            for (int i = 0; i < 20; i++)
            Console.Write(virsusApacia);
            Console.WriteLine(" ");

            //Išveskite į ekraną norimo dydžio tuščiavidurį kvadratą iš žvaigždučių.

            Console.WriteLine(" ");
            char kvadratas = '*';
            for (int i = 0; i < 3; i++) 
            Console.Write(kvadratas);
            Console.WriteLine(kvadratas + "  " + kvadratas);
            Console.WriteLine(kvadratas + "  " + kvadratas);
            Console.WriteLine(kvadratas + "  " + kvadratas);
            for (int i = 0; i < 4; i++)
            Console.Write(kvadratas);
            Console.WriteLine(" ");

            //Susikurkite reikiamus kintamuosius užduočiai atlikti. Į ekraną išveskite: Automobilio {markė} {modelis} ({metai} m.) rida - {rida} km.
            //Tarp { } nurodyti reikiami kintamieji, šiose vietose jų reikšmės turi būti įstatytos.

            Console.WriteLine(" ");
            String marke = "Audi";
            String modelis = "A6";
            int metai = 2013;
            float rida = 152986.2f;
            Console.WriteLine("Automobilio" + " " + marke + " " + modelis + " " + "(" + metai + "m." + ")" + " " + "rida" + " " + rida + " " + "km.");
            Console.WriteLine(" ");

            //Išveskite į ekraną dviejų skaičių sumą, skirtumą, sandaugą ir dalmenį,
            // kiekvieną kartą nurodant atliekamą veiksmą ir šių skaičių reikšmes.
            // Pvz.:
            // 4 + 5 = 9
            // 4 - 5 = -1

            

            //Išveskite į ekraną pasirinktą skaičių, jo kvadratą ir jį pakeltą trečiuoju laipsniu.

            
        }
    }
}


