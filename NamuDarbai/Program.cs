using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamuDarbai
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zaidimas();
            //pirmauzduotis();
            //pirmapavydzine();
            //antrauzduotis();
            //treciauzduotis();
            //ketvirtaUzduotis();
            //penktaUzduotis();
            //sestauzduotis();
            //septinta();
            Zaidimas2();




            Console.ReadLine();
        }

        static void Zaidimas()
        {
            Random random = new Random();
            int SlaptasSkaicius = random.Next(0, 11);
            int IvestasSk = 0;
            int spejimuskaicius = 1;


            while (IvestasSk != SlaptasSkaicius && spejimuskaicius <= 3)
            {
                Console.WriteLine("Iveskite slaptaji skaiciu, nuo 1 iki 10: ");
                IvestasSk = Convert.ToInt32(Console.ReadLine());

                if (IvestasSk > SlaptasSkaicius)
                {
                    Console.WriteLine("Slaptas skaicius yra mazesnis");
                }
                else if (IvestasSk < SlaptasSkaicius)
                {
                    Console.WriteLine("Slaptas skaicius yra Didesnis");

                    spejimuskaicius++;

                }

            }
            if (IvestasSk == SlaptasSkaicius)
            {
                Console.WriteLine("Atspejote t.y.: " + SlaptasSkaicius);
            }
            else
            {
                Console.WriteLine("Isnaudojote spejimu limita");
            }





        }
        static void pirmauzduotis()
        {
            Console.WriteLine("Iveskite savo varda: ");
            String vardas = Console.ReadLine();
            Console.WriteLine("Iveskite savo amziu: ");
            int amzius = Convert.ToInt32(Console.ReadLine());

            if (amzius >= 18)
            {
                Console.WriteLine("Jus galite balsuoti!");
            }
            else
            {
                Console.WriteLine(vardas + " " + "Luktelekite dar: " + (18 - amzius) + " " + "Metus");
            }

        }
        static void pirmapavydzine()
        {
            Console.Write("Iveskite savo varda:");
            string vardas = Console.ReadLine();

            Console.Write("Iveskite savo amziu:");
            int amzius = Convert.ToInt32(Console.ReadLine());

            if (120 > amzius && amzius >= 18)
            {
                Console.WriteLine("\nJus jau galite balsuoti.");
            }
            else if (0 < amzius && amzius < 18)
            {
                Console.WriteLine("\nGalesite balsuoti uz {0} metu", 18 - amzius);
            }
            else
            {
                Console.WriteLine("\nJus dar negimes arba jau mires...");
            }
        }


        static void antrauzduotis()
        {
            Console.WriteLine("Sveiki, jus paskambinote i mokesciu inspekcija, pasirinkite ko noresite: ");
            Console.WriteLine("Spauskite 1 jeigu norite kalbėti deklaravimo klausimais.");
            Console.WriteLine("Spauskite 2 jeigu domina individuali veikla. ");
            Console.WriteLine("Spauskite 3 jeigu norite kalbėti apie mokesčių reformą.");
            Console.WriteLine("Spauskite 4 jeigu norite pagalbos dėl PVM lengvatos.");
            Console.WriteLine("5.MENIU in english");
            Console.WriteLine("6.Baigti pokalbi.");

            Console.Write("Jusu pasirinkimas yra:  ");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    Console.WriteLine("Gintare klauso Deklaravimo klausimais");
                    break;
                case 2:
                    Console.WriteLine("Gintare klauso Individualios veiklos klausimais");
                    break;
                case 3:
                    Console.WriteLine("Gintare klauso Mokesciu klausimais");
                    break;
                case 4:
                    Console.WriteLine("Gintare klauso PVM klausimais");

                    break;
                case 5:
                    Console.WriteLine("Meniu keiciame i angliska");
                    break;
                case 6:
                    Console.WriteLine("Dekui, viso gero!");
                    break;
                default:
                    Console.WriteLine("tokio pasirinkimo nera");
                    break;
            }






        }
        static void treciauzduotis()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(i + ",");
            }
        }
        static void ketvirtaUzduotis()
        {
            for (int i = -22; i < 20; i++)
            {
                Console.WriteLine(i);

            }
        }

        static void penktaUzduotis()
        {
            for (int i = 50; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        static void sestauzduotis()
        {
            int i = 0;

            while (i <=
 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        static void septinta()
        {
            String[] masyvas = new[] { "jonas", "petras", "kazimieras" };
            Console.WriteLine("Vardai: {0}, {1}, {2}", masyvas[0], masyvas[1], masyvas[2]);

            for (int i = 0; i < masyvas.Length; i++)
            {
                Console.WriteLine(masyvas[i]);

            }
        }
        static void Zaidimas2()
        {
            int pirmaskalusimas1 = 1;
            int pasirinkimas2 = 2;
            int pasirinkimas3 = 3;

            int atsakymas1 = 0;
            int atsakymas2 = 0;
            int atsakymas3 = 0;

            int spejimuskaicius = 1;
            int spejimuskaicius2 = 1;
            int spejimuskaicius3 = 1;

            if (atsakymas1 == 0)
            {
                while (pirmaskalusimas1 != atsakymas1 && spejimuskaicius <= 3)
                {
                    Console.WriteLine("Kas Lietuvos sostine? ");
                    Console.WriteLine("1.Vilnius");
                    Console.WriteLine("2.Siauliai");
                    Console.WriteLine("3.Kaunas");
                    Console.WriteLine("4.Kelme");
                    Console.WriteLine("Iveskite savo atsakyma:");
                    atsakymas1 = Convert.ToInt32(Console.ReadLine());
                    spejimuskaicius++;
                    Console.Clear();
                }
            }
            if (spejimuskaicius > 3) { Console.WriteLine("Virsijote mandymu limita"); }


            else if (spejimuskaicius <= 3)
            {
                while (pasirinkimas2 != atsakymas2 && spejimuskaicius2 <= 3)
                {
                    Console.WriteLine("Kokia zoles spalva? ");
                    Console.WriteLine("1.Melyna");
                    Console.WriteLine("2.Zalia");
                    Console.WriteLine("3.Raudona");
                    Console.WriteLine("4.Geltona");
                    Console.WriteLine("Iveskite savo atsakyma:");
                    atsakymas2 = Convert.ToInt32(Console.ReadLine());
                    spejimuskaicius2++;
                    Console.Clear();
                }
            }

            if (spejimuskaicius2 > 3) { Console.WriteLine("Virsijote mandymu limita"); }

            else if (spejimuskaicius <= 3 && spejimuskaicius2 <= 3)
            {
                while (pasirinkimas3 != atsakymas3 && spejimuskaicius3 <= 3)
                {
                    Console.WriteLine("Kas Lietuvos prezidentas? ");
                    Console.WriteLine("1.Normanas");
                    Console.WriteLine("2.Antanas");
                    Console.WriteLine("3.Dalia");
                    Console.WriteLine("4.Kristina");
                    Console.WriteLine("Iveskite savo atsakyma:");
                    atsakymas3 = Convert.ToInt32(Console.ReadLine());
                    spejimuskaicius3++;
                    Console.Clear();
                }
            }

            if (spejimuskaicius3 > 3) { Console.WriteLine("Virsijote mandymu limita"); }

            if (pirmaskalusimas1 == atsakymas1 && pasirinkimas2 == atsakymas2 && pasirinkimas3 == atsakymas3)
            {
                Console.WriteLine("Jus laimejote milijona!");
            }

        } // nebaigtas


    }
}


