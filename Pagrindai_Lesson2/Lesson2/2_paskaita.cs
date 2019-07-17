using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzdavinys1();
            //UzdavinysVienas();
            //UzdavinysAntras();
            //UzdavinysTrys();
            //Uzdavinys2paskaita();
            //ifuUzdaviniai();
            ifuzdaviniai2();


            Console.ReadLine();



        }
        static void Uzdavinys1()
        {
            Console.Write("Iveskite skaiciu nr.1:  ");

            int pirmasSK = Convert.ToInt32(Console.ReadLine());


            Console.Write("Iveskite skaiciu nr.2:  ");

            int antrasSK = Convert.ToInt32(Console.ReadLine());

            int suma = pirmasSK + antrasSK;
            int skirtumas = pirmasSK - antrasSK;
            double dalyba = (double)pirmasSK / antrasSK;


            Console.WriteLine("\nSuma yra: {0} \nSkirtumas yra: {1}", suma, skirtumas);
            Console.WriteLine("Sandauga = {0} \nDalyba= {1}", pirmasSK * antrasSK, dalyba);
            Console.WriteLine("Sandauga = " + pirmasSK * antrasSK); // antras budas ta pati parasyti
            Console.WriteLine(Math.PI); // Pi reiksme jau yra Math bibliotekoje.

            Console.ReadLine();
        }

        static void UzdavinysVienas()
        {


            Console.WriteLine("Iveskite apskritimo spinduli: ");
            double apskritimospindulys = Convert.ToInt32(Console.ReadLine());

            double ilgis = 2 * Math.PI * apskritimospindulys;
            double plotas = Math.PI * apskritimospindulys * apskritimospindulys;

            Console.WriteLine("Ilgis yra: {0} Plotas yra: {1}", ilgis, plotas);
            Console.ReadLine();
        }

        static void UzdavinysAntras()
        {
            Console.WriteLine("Iveskite atstuma, m: ");
            double atstumas = Convert.ToDouble(Console.ReadLine());
            double atstumokeitimas = atstumas / 1000;

            Console.WriteLine("Iveskite laika, sek.: ");
            double laikas = Convert.ToDouble(Console.ReadLine()); // galima iskarto gale padalinti is 1000
            double laikokeitimas = laikas / 3600;

            double greitis = atstumokeitimas * laikokeitimas;

            Console.WriteLine("Jusu greitis: {0} km/h", greitis);
            Console.ReadLine();



        }

        static void UzdavinysTrys()
        {
            Console.WriteLine("Iveskite savo varda: ");
            String vardas = Console.ReadLine();

            Console.WriteLine("Iveskite savo pavarde");
            String pavarde = Console.ReadLine();

            Console.WriteLine("Kur gimete? : ");
            String gimtine = Console.ReadLine();

            Console.Clear();

            Console.WriteLine(vardas + " " + pavarde + " deginasi " + gimtine);
            Console.ReadLine();




        }

        static void Uzdavinys2paskaita()
        
{
            Console.WriteLine("Iveskite skaiciu(A): ");
            double pirmassk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite skaiciu (B): ");
            double antrassk = Convert.ToInt32(Console.ReadLine());

            if (pirmassk > antrassk)
            {
                Console.WriteLine("A yra daugiau uz B");
                Console.ReadLine();
            }
            else if (pirmassk < antrassk)
            {
                Console.WriteLine("A yra maziau uz B");
                Console.ReadLine();
            }
            else
                Console.WriteLine("A lygus B");
                Console.ReadLine();
            }

        static void ifuUzdaviniai()
        {
            Console.WriteLine("Iveskite skaiciu(A): ");
            double A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite skaiciu(B): ");
            double B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite skaiciu(C): ");
            double C = Convert.ToInt32(Console.ReadLine());

            if (A > B && A > C)
            {
                Console.WriteLine("Skaicius A yra didziausias");
            }
            else if (B > A && B > C)
            {
                Console.WriteLine("Skaicius B yra didziausias");
            }
            else
            {
                Console.WriteLine("Skaicius C yra didziausias");

            }



        }
        static void ifuzdaviniai2()
        {
            Console.WriteLine("Iveskite skaiciu(A): ");
            double A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite skaiciu(B): ");
            double B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite skaiciu(C): ");
            double C = Convert.ToInt32(Console.ReadLine());

            if (A > B && A < 100)
            {
                Console.WriteLine("Tinka 1 salyga");
            }
            if (B > 0  && B > A)
            {
                Console.WriteLine("Tinka 2 salyga");
            }
            if (A>B && A>C || A > 0)
            {
                Console.WriteLine("Tinka 3 salyga ");
            }
            if ((C >= 5 && C<=10) || (C > A) || (A> B))
            {
                Console.WriteLine("Tinka 4 salyga");
            }
            else
            {
                Console.WriteLine("Niekas netiko");
            }
          

        }

        static void skaciavimas(){
            String zodis = "Labas";
            Console.WriteLine(FrontBack(zodis));
            
       
        }

        





    }



    }
       
    

    
    



