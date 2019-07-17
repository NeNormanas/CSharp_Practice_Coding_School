using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            //PARDUOTUVES (Objektai)

            Parduotuve batuKalnas = new Parduotuve("Batu Kalnas", "Zirmunu g. 4, Vilnius", 2, 2011);
            Parduotuve Danija = new Parduotuve("Danija", "Gedimino pr. 9, Vilnius", 1, 1999);

            batuKalnas.GetBatai();
            foreach (var item in batuKalnas.batai)
            {
                Console.WriteLine(item.Gamintojas + "  " + item.Kaina);
            }
            //BATAI (Objektai)

            Batas BatasPirmas = new Batas("NIKE", 46, "Melyna", "Zomsas", 99, 30);
            Batas BatasAntras = new Batas("ADIDAS", 36, "Ruda", "Oda", 129, 50);
            Batas BatasTrecias = new Batas("Timberland", 41, "Rozine", "Veliuras", 35, 5);
            Batas BatasKetvirtas = new Batas("Aduke", 30, "Geltona", "Oda", 200, 10);
            Batas BatasPenktas = new Batas("Hilfiger", 51, "Raudona", "Zomsas", 199, 80);

            //DARBUOTOJAI (Objektai)

            Darbuotojas DarbPirmas = new Darbuotojas("Jonas", "Kucinskas", 2004, "Pardavejas", 400);
            Darbuotojas DarbAntras = new Darbuotojas("Maryte", "Prunske", 2000, "Vadovas", 2400);
            Darbuotojas DarbTrecias = new Darbuotojas("Kazys", "Jasikevicius", 2010, "Sandelininkas", 400);


            //VEIKSMAI SU objektais ir Klasemis

            BatasPirmas.Informacija();

            DarbTrecias.Informacija();

            Danija.Informacija();

            List<Batas> BatuSarasas = new List<Batas>();
            BatuSarasas.Add(BatasPirmas);
            BatuSarasas.Add(BatasAntras);
            BatuSarasas.Add(BatasTrecias);
            BatuSarasas.Add(BatasKetvirtas);
            BatuSarasas.Add(BatasPenktas);

            int skaicius = 1;
            Console.WriteLine("\n Batu sarasas: ");
            foreach (var item in BatuSarasas)
            {
                
                Console.WriteLine(" {0}. ", skaicius);
                item.Informacija();
                skaicius++;
            }

            int VisuBatuVerte = 0;

            // PIRMAS BUDAS
            for (int i = 0; i < BatuSarasas.Count; i++)
            {
                VisuBatuVerte = VisuBatuVerte + BatuSarasas[i].Kaina;
            }

            int VisuBatuverte2budas = 0;
            double VisuBatuVertePONuolaidos = 0;
            // ANTRAS BUDAS -PAPRASTESNIS

            foreach (var item in BatuSarasas)
            {
                VisuBatuverte2budas = VisuBatuverte2budas + item.Kaina;
                VisuBatuVertePONuolaidos = VisuBatuVertePONuolaidos + item.KainaSuNuolaida();

            }

            Console.WriteLine("Visu batu verte {0} arba {1}", VisuBatuVerte, VisuBatuverte2budas);
            Console.WriteLine("Visu batu verte po Nuolaidos: {0}", VisuBatuVertePONuolaidos);
            





            Console.ReadLine();


        }
    }
}
