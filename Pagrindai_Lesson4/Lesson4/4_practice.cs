using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            //ciklaswhile();
            //cikasWhile2();
            //cikalasSkaiciuotuvas();
            zaidimas();
            //masyvai1();
            //masyvouzpildymas();



            Console.ReadLine();
        }
        static void ciklaswhile()
        {
            Console.WriteLine("Pasirinkite viena is dvieju: 1.Laptopas   2.Stacionaras");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());
            Console.Clear();


            while (pasirinkimas <= 0 || pasirinkimas > 2)
            {
                Console.WriteLine("TOkio pasirinkimo nera!");
                Console.WriteLine("Veskite dar syki: ");
                pasirinkimas = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

            }

            if (pasirinkimas == 1)
            {
                Console.WriteLine("Jus pasirinkote Laptopa");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Jus pasirinkote stacionara");
                Console.ReadLine();
            }
        }
        static void cikasWhile2()
        {
            Console.WriteLine("Iveskite skaiciu: ");
            int ivestasSkaicius = Convert.ToInt32(Console.ReadLine());
            int suma = 0;

            while (ivestasSkaicius > 0)
            {
                if (ivestasSkaicius % 2 == 0)
                {

                    suma = suma + ivestasSkaicius;

                }

                ivestasSkaicius--;


            }


            Console.WriteLine("SUma {0}", suma);
        }

        static void cikalasSkaiciuotuvas()
        {
            int pasirinkimas = 1;

            while (pasirinkimas == 1)
            {
                Console.Write("Iveskite 1-a skaiciu: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Iveskite norima atlikti veiksma (+; -; *; /): ");
                var aritmetinisVeikmas = Console.ReadLine();

                Console.Write("Iveskite 2-a skaiciu: ");
                double b = Convert.ToDouble(Console.ReadLine());


                switch (aritmetinisVeikmas)
                {
                    case "+":
                        Console.WriteLine("Suma: {0}", a + b);


                        break;
                    case "-":
                        Console.WriteLine("Skirtumas: {0}", a - b);

                        break;
                    case "*":
                        Console.WriteLine("Sandauga: {0}", a * b);

                        break;
                    case "/":
                        Console.WriteLine("Dalyba: {0}", a / b);

                        break;
                    default:
                        Console.WriteLine("Tokio veiksmo nera.");

                        break;



                }
                Console.WriteLine("Ar norite darkarta naudoti skaicuotuva? 1.TAIP  2.NE");
                pasirinkimas = Convert.ToInt32(Console.ReadLine());


            }

            Console.WriteLine("Aciu, kad naudojotes skaiciuotuvu, VISO GERO!");


        }

        static void zaidimas()
        {
            int slaptasSakaicius = 7;
            Console.WriteLine("Prasome Ivesti slaptaji skaiciu: ");
            int IvestasSkaicius = Convert.ToInt32(Console.ReadLine());



              }



        }// nebaigtas

        static void masyvai1()
        {
            int[] skaiciai = new int[5];
            skaiciai[0] = 11;
            skaiciai[1] = 13;
            skaiciai[2] = 3;
            skaiciai[3] = 1135;
            skaiciai[4] = 0;

            Console.WriteLine(skaiciai[4]);
            Console.WriteLine(skaiciai.ElementAt(3));




        }
        static void masyvouzpildymas()
        {
            int[] masyvas = new int[10];

            for (int i = 0; i < 10; i++)// masyvo uzpildymas duomenimis
            {
                Console.Write("Iveskite {0}-aji skaiciu: ", i+1);
                int ivestasSk = Convert.ToInt32(Console.ReadLine());
                masyvas[i] = ivestasSk;



                masyvas[i] = i;
               
            }
            masyvas[0] = 99;

            // masyvo spaudinimas
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(masyvas[i]);

            }

        }


    }
}
