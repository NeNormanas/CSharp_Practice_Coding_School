using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {

            //string vardas = "Normanas";
            //string pavarde = "Necionis";
            //int amzius = 24;

            //Console.WriteLine(vardas);
            //Console.WriteLine(pavarde);
            //Console.WriteLine(amzius);

            //Console.Write(vardas);
            //Console.Write(pavarde);
            //Console.Write(amzius);

            //Console.Write(vardas + "  " + pavarde + " \nir mano amzius: " + amzius);
            //Console.Write("Mano vardas: {0} \nMano pavarde: {1} \nMano amzius: {2}", vardas, pavarde, amzius);
            //Console.ReadLine();

            //Console.WriteLine("iveskite teksta: ");
            //string tekstas = Console.ReadLine();
            //Console.WriteLine("Jus ivedete: " + tekstas);
            //Console.ReadLine();

            //int skaicius = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(skaicius);


            // pirma uzduotis 

            Console.WriteLine("Iveskite savo varda: ");
            string vardas = Console.ReadLine();

            Console.WriteLine("Iveskite megstamiausios spalvos pirma raide: ");
            char raide = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("iveskite pirmaji skaiciu: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite antraji skaiciu: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Jusu vardas yra: {0} \nJusu megstamiausios spalvos raide: {1} \nJusu pirmas skaicius: {2} \nJusu antras skaicius: {3}", vardas, raide, skaicius1, skaicius2);

            Console.ReadLine();







        }
    }
}
