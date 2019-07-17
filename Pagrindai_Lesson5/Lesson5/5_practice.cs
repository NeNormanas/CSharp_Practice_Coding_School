using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            //metodas1();
            //int amziusmetais = 29;
            //metodas2("Normanas", amziusmetais);
            //double atsakymas = MetodasKurisGrazinaVidurki(10, 9);
            //Console.WriteLine(atsakymas);
            // pvz galima ir taip: 
            //metodas2("Andrius", MetodasKurisGrazinaVidurki(10, 9));
            //lsitas();
            //SkaiciuSarasas();
            //ForEachpavyzdys();
            uzduotis1();




            Console.ReadLine();

        }
        // metodas, kuris nieko negrazina, be parametru;

        static void metodas1()
        {
            Console.WriteLine("Sveiki is pirmo metodo.");

        }
        // metodas, kuris nieko negrazina, su parametrais
        static void metodas2(string vardas, double amzius)
        {
            Console.WriteLine("Jusu vardas {0} ir amzius {1}", vardas, amzius);

        }
        // Metodas, kuris priimaparametrus ir grazina reiksme

        static double MetodasKurisGrazinaVidurki(double A, double B)
        {
            double vidurkis = (A + B) / 2;


            return vidurkis;
        }

        static void lsitas()
        {
            List<string> vardai = new List<string>() { "Jonas", "Petras", "Kazimieras" };
            vardai.Add("Danute");
            vardai.Add("Gintare");

            for (int i = 0; i < vardai.Count; i++)
            {

                Console.WriteLine("{0}. {1}", i + 1, vardai[i]);

            }
            vardai.RemoveAt(vardai.Count - 1); // istrins paskutini varda
            Console.WriteLine(vardai.Count);

            vardai.IndexOf("Petras");
            Console.WriteLine(vardai);



        }
        static void SkaiciuSarasas()
        {
            List<int> skaiciai = new List<int>() { 4, 6, 78, 42 };
            List<int> skaiciai2 = new List<int>() { 4, 6, 78, 42 };


            Console.WriteLine(skaiciai.IndexOf(78));
            Console.WriteLine(skaiciai.Contains(42));
            // Console.WriteLine(skaiciai.Concat());
            Console.WriteLine(skaiciai.Count);
            Console.WriteLine(skaiciai.Remove(6));
            skaiciai.RemoveAt(0);
            Console.WriteLine(skaiciai.Count);
            skaiciai.Insert(0, 17);
            Console.WriteLine(skaiciai[0]);

            Console.WriteLine(skaiciai.Contains(42));

            List<int> skaiciai3 = new List<int>();
            //var dviejusarasujunginys = skaiciai.Concat(skaiciai2);

            //Console.WriteLine(dviejusarasujunginys.Count()); // susumuojame dvieju sarasu elementu skaiciu

            Console.WriteLine(skaiciai.Sum());

            for (int i = 0; i < skaiciai2.Count; i++)
            {
                Console.WriteLine(skaiciai2[i]);

            }



        }

        static void ForEachpavyzdys()
        {
            List<string> vardai = new List<string>() { "Jonas", "Petras", "Ona" };

            foreach (var item in vardai)
            {
                Console.WriteLine(item);
            }

        }
        static void uzduotis1()
        {
            Console.WriteLine("Iveskite penkias spalvas");

            String Splava1 = Console.ReadLine();
            String Splava2 = Console.ReadLine();
            String Splava3 = Console.ReadLine();
            String Splava4 = Console.ReadLine();
            String Splava5 = Console.ReadLine();




            List<string> sarasas = new List<string>();
            sarasas.Add(Splava1);
            sarasas.Add(Splava2);
            sarasas.Add(Splava3);
            sarasas.Add(Splava4);
            sarasas.Add(Splava5);

            sarasas.Sort();
            sarasas.Contains("Raudona");
            sarasas.Remove("Raudona");
            Console.WriteLine(sarasas.Count);


           



            //AtvaizduotiSuCikluFor(sarasas);

            AtvaizduotisuWHILEciklu(sarasas);
            AtvaizduotiSUFOREACH(sarasas);


                
           

        }


        static void AtvaizduotiSuCikluFor (List<string> kazkokssarasas)
        {
            for (int i = 0; i < kazkokssarasas.Count; i++)
            {
                Console.WriteLine(kazkokssarasas[i]);
            }
        }



        static void AtvaizduotisuWHILEciklu (List<string> kazkoksaisarasiukas)
        {
            int i = 0;

            while (i < kazkoksaisarasiukas.Count){

                Console.WriteLine(kazkoksaisarasiukas[i]);
                i++;
            }
        }

        static void AtvaizduotiSUFOREACH (List<string> kazkokssarasiuskasss)
        {
            foreach (var item in kazkokssarasiuskasss)
            {
                Console.WriteLine("{0}. ", item);
            }
        }

    }
}
