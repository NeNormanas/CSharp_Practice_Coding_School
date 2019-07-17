using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{

    class Program
    {
        static void Main(string[] args)
        {
            //switchai();
            //skaiciuotuvas();
            //aparatas();
            //ciklai1();
            //ciklai2();
            //ciklai3();
            ciklai4();
            Console.ReadLine();
        }
        static void switchai()
        {
            Console.Write("Iveskite skaiciu pirmaji: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Iveskite skaiciu antraji: ");
            int B = Convert.ToInt32(Console.ReadLine());


            Console.Write("Iveskite skaiciu treciaji: ");
            int C = Convert.ToInt32(Console.ReadLine());

            switch (A)
            {
                case 1:

                    Console.WriteLine("SKaiciu suma" + " " + (A + B + C));
                    Console.WriteLine(DateTime.Now);
                    break;
                case 2:
                    Console.WriteLine(A - C);
                    break;
                case 3:
                    Console.WriteLine(B - C);
                    break;


                default:
                    Console.WriteLine("KLAIDA");

                    break;


            }
        }
        static void skaiciuotuvas()
        {
            Console.Write("Iveskite skaiciu pirmaji: ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Iveskite norima atlikti veiksma(+; -; *; /)");
            var aritmetinisVeiksmas = Console.ReadLine();

            Console.Write("Iveskite skaiciu antraji: ");
            double B = Convert.ToDouble(Console.ReadLine());



            switch (aritmetinisVeiksmas)
            {
                case "+":
                    Console.WriteLine(A + B);
                    break;
                case "-":
                    Console.WriteLine("Atsakymas: {0} ", A - B);
                    break;
                case "*":
                    Console.WriteLine(A * B);
                    break;
                case "/":
                    Console.WriteLine(A / B);
                    break;

                default:
                    Console.Write("Tokio veiksmo nera");
                    break;
            }

        }
        static void aparatas()
        {
            Console.WriteLine("MENU: \n1.Limonadas  \n2.Arbata  \n3.Kakava  \n4.Kava  \n5.Nieko");
            Console.WriteLine("Sveiki, pasirinkite numerį (1,2,3,4,5)");
            String pasirinkimas = Console.ReadLine();
            Console.Clear();

            switch (pasirinkimas)
            {
                case "1":
                    Console.WriteLine("Prašome paimti Limonadą");
                    break;
                case "2":
                    Console.WriteLine("Prašome paimti Arbata");
                    break;
                case "3":
                    Console.WriteLine("Prašome paimti Kakava");
                    break;
                case "4":
                    Console.WriteLine("Prašome paimti Kava");
                    break;
                case "5":
                    Console.WriteLine("Viso gero, neimkite nieko ");
                    break;

                default:
                    Console.WriteLine("Blogai pasirinkote!");
                    break;
            }
        }

        // CIKLAI
        static void ciklai1()
        {
            for (int i = 0; i <= 20; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        static void ciklai2()
        {
            for (int i = 0; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("{0},", i);
                }

            }

        }
        static void ciklai3()
        {
            Console.WriteLine("Iveskite rezio pradzios skaiciu:");
            int pradzia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite rezio pabaigos skaiciu:");
            int pabaiga = Convert.ToInt32(Console.ReadLine());

            if (pradzia > pabaiga)
            {
                Console.WriteLine("blogi reziai");

            }
            else
            {
                for (int i = pradzia; i <= pabaiga; i++)
                {

                    int kvadratas = i * i;

                    Console.WriteLine("{0} {1}", i, kvadratas);
                    Console.WriteLine(i + " " + Math.Pow(i, 2)); // 2 budas

                }
            }

        }
        static void ciklai4()
        {
            int suma = 0; 

            for (int i = 999; 0 < i && i < 1000; i--)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    suma = suma + i; // arba suma += i;
                }
            }
            Console.WriteLine("Rezultatas: {0}", suma);
        }
    }
}


