using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7 // KLASES
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobilis masina1 = new Automobilis("Volkswagen", 2000, "Juoda", 200000, "Bora", 10.23, 180); // sakom kad is klases automobilis sukurk mum objekta volksvagen

            double KmPerMetus = masina1.kilometraiPerMetus();

            Automobilis masina2 = new Automobilis("Opel", 2002, "Sidabrine", 300000, "Vectra", 30, 200);

            double masina2permetus = masina2.kilometraiPerMetus();

            // vienas variantas atvaizduoti
            //Console.WriteLine("Pirmojo auto marke: {0}, kilometrai per metus: {1}", masina1.Marke, KmPerMetus);
            //Console.WriteLine("Antrojo auto marke: {0}, kilometrai per metus: {1}", masina2.Marke, masina2.kilometraiPerMetus());

            //Kita atvaizdavimo 

            masina1.Spauzdinti();
            masina2.Spauzdinti();





            List <Automobilis> autosarasas = new List<Automobilis>();
            autosarasas.Add(masina1);
            autosarasas.Add(masina2);

            foreach (var item in autosarasas)
            {
                Console.WriteLine(item.Marke);
            }
          




            Console.ReadLine();




        }
    }

}
