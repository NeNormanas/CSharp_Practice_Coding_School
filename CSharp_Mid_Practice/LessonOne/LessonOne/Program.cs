using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOne
{
    class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine("Hello world");
            //Console.ReadLine();
            //int dienos = DateTime.DaysInMonth(2019, 06);
            //Console.ReadLine();
            
            //Console.WriteLine($"Sveiki, \"2019-06 menuo\" turi {dienos} dienu" ); // \r nukerpa kas jo sito simbolio
            //Console.ReadKey();



            // PIRMA UZDUOTIS 

            // 1 variantas
            Console.WriteLine("Vardas: Normanas\nPavarde: Necionis\nAmzius: 24 metai");
            Console.ReadKey();

            Console.WriteLine();

            // 2 variantas
            Console.WriteLine("\nVardas: Normanas\nPavarde: Necionis\nAmzius: 24 metai");
            Console.ReadLine();

            // 3 variantas
            Console.WriteLine("\nVardas: {0}, \nPavarde: {1}, \nAmzius: {2}", "Normanas", "Necionis", 24);
            Console.ReadLine();

            // ANTRA UZDUOTIS  

            double kintamasis, kintamasis4 = 12.5; // spauzdina tik paskutini po kableliu
            int kintamasis2 = -100;
            char simbolis = 'a';
            string zodis = "uzduotis";
            bool logoneReiksme = false;

          


            Console.WriteLine("Iveskite teksta: ");
            string userInput = Console.ReadLine();
            Console.WriteLine(userInput);
            Console.ReadKey();

            Console.WriteLine("Iveskite varda: ");
            string name = Console.ReadLine();

            Console.WriteLine("Iveskite pavarde: ");
            string surname = Console.ReadLine();

            Console.WriteLine($"Jusu vardas {name}, Jusu pavarde {surname}");

            Console.WriteLine("Iveskite skaiciu: ");
            float skaicius = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(skaicius);
           
            Console.ReadLine();
        }
    }
}
