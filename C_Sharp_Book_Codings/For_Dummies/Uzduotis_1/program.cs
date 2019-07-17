using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Each line you enter will be"
                        + "added to a sentence until you"
                        + "enter EXIT or QUIT");
            Console.WriteLine("kas yra nx");
            string sentense = "";
            int ilgis = sentense.Length;
            Console.WriteLine(ilgis);
            
            Console.ReadLine();

            for (int i = 0; i == sentense.Length; i++)
            {
                Console.WriteLine("Enter a string");
                string line = Console.ReadLine();
                string[] terms = { "EXIT", "exit", "QUIT", "quit" };
                bool iseiti = false;
                foreach (string term in terms)
                {
                    if (string.Compare(line, term) == 0)
                    {
                        iseiti = true;
                    }
                }
                if (iseiti == true)
                {
                    break;
                }

                sentense = string.Concat(sentense, line);
                Console.WriteLine("\n jus ivedete:" + sentense);

            }

            Console.WriteLine("\n Total sakinys:\n" + sentense);
            Console.ReadLine();

        }
    }
}
