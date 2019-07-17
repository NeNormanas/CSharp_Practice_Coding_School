using System;
using System.Collections.Generic;
using System.Linq;

namespace LessonSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Pralaimėjome trejas rungtynes iš eilės, todėl privalėjome žaisti geriau." +
                " Manau, visi buvo papildomai motyvuoti šiam mačui. Jaučiau, kad turnyre nepateisinome lūkesčių ir buvome motyvuoti nebeleisti sau teisės pralaimėti. " +
                "Mums tai buvo gyvenk arba mirk vakaras ";


            string redaguotasTextas = text.Replace(".", string.Empty);
            string redaguotasTextas2 = redaguotasTextas.Replace(",", string.Empty);

            List<string> tekstasSarase = redaguotasTextas2.Split(new char[] { ' ' }).ToList();

            tekstasSarase.Max();

            tekstasSarase.RemoveAt(35);

            int max = 0;
            string ilgiausias = "";

            for (int i = 0; i < tekstasSarase.Count; i++)
            {
                string temp =  tekstasSarase[i];

                if (temp.Length > max)
                {
                    max = temp.Length;

                    ilgiausias = temp;
                }

            }
            Console.WriteLine(ilgiausias);
            Console.WriteLine(tekstasSarase.Contains("Split"));

            string randomText = "";

            Random randomas = new Random();
          

            List<string> naujas = new List<string>();

            for (int i = 0; i < tekstasSarase.Count; i++)
            {
                int NR = randomas.Next(0, tekstasSarase.Count);

                naujas.Add(tekstasSarase[NR]);
                

            }

            
            Console.Clear();

            string paragrafas;

            paragrafas = string.Concat(naujas.ToArray());

           string paragrafas2 = string.Join(" ", naujas);

            Console.WriteLine(paragrafas);
            Console.WriteLine(paragrafas2);
           
            Console.ReadKey();

            naujas.ForEach(Console.WriteLine);




            Console.ReadKey();


            Console.WriteLine(skaiciuokle(7, 6) * 60 + " min"); ;
            Console.ReadKey();

            List<int> numbers = new List<int>();

            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                int nr = rnd.Next(1, 100);

                numbers.Add(nr);
            }

            Console.WriteLine(numbers.RemoveAll(LowerTwenty)); // parodo kiek pasalino elementu, kurie atitiko funkcija t.y. mazesni uz 20.

            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Average());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Max());





            Console.ReadKey();

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine(numbers.Count);

            numbers.RemoveAll(OverEighty); // istryniau is saraso kurie daugiau uz 80.

            Console.WriteLine(numbers.Count);
            numbers.Sort();
            numbers.ForEach(Print);



            Console.ReadLine();








            List<int> skaiciai = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };

            Console.WriteLine(skaiciai.IndexOf(8)); // parodo kuriame indexe yra skliaustuose ieskoma reiksme

            Console.ReadKey();



            ////
            List<int> atsakymas = skaiciai.FindAll(Ieskoma);
            foreach (var item in atsakymas)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            //////
            ///

            Console.WriteLine(skaiciai.Exists(paieska)); // tikslas surasti bent viena kuris tenkina salyga

            Console.ReadKey();

            Console.WriteLine(skaiciai.RemoveAll(Ieskoma)); // parodo kiek elementu istryne



            foreach (var item in skaiciai) // atspauzdinu likusius po istrynimo
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();




            skaiciai.RemoveAll(TestEven); // pasalina tuos elementus kurie yra true.

            foreach (var item in skaiciai)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();


            skaiciai.Add(78);
            skaiciai.Insert(5, 88);

            foreach (var item in skaiciai)
            {
                Console.WriteLine(item);
            }

            List<int> skaiciai2 = new List<int>();
            skaiciai2.Add(44);
            skaiciai2.Add(55);

            skaiciai.AddRange(skaiciai2);

            foreach (var item in skaiciai)
            {
                Console.WriteLine(item);
            }


            int[] skaiciai3 = { 77, 99 };
            skaiciai.InsertRange(0, skaiciai3);

            foreach (var item in skaiciai)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();



            skaiciai.RemoveRange(0, 10);

            foreach (var item in skaiciai)
            {
                Console.WriteLine(item);
            }




            Console.WriteLine(skaiciai.Contains(90));

            Console.WriteLine();

            skaiciai.ForEach(Console.WriteLine); // visoe kitose metoduose kur praso prediction. ty reikia paduoti funkcija.

            skaiciai.ForEach(PrintList); // print List musu sukurta funkcija



            Console.ReadLine();


        }
        // FUNKCIJOS 


        static double skaiciuokle(double greitis, double atstumas)
        {

            return atstumas / greitis;

        }

        static bool LowerTwenty(int x)
        {
            if (x < 20)
            {
                return true;
            }
            return false;
        }

        static void Print(int x)
        {
            if (x % 2 == 0)
            {
                Console.Write(x + " ");
            }
        }


        static bool OverEighty(int x)
        {
            if (x > 80)
            {
                return true;
            }

            return false;
        }

        static void PrintList(int x)
        {
            Console.Write(x + ",");
        }
        static bool TestEven(int x)
        {
            return x % 2 == 0;
        }

        static bool Ieskoma(int x)
        {
            if (x % 2 == 0)
            {
                return true;
            }
            return false;
        }

        static bool paieska(int x)
        {
            if (x % 2 != 0)
            {
                return true;
            }
            return false;
        }



    }
}
