using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Dummies
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Each line you enter will be"
                        + "added to a sentence until you"
                        + "enter EXIT or QUIT");
            string sentense = "";

            for (int i = 0; i > sentense.Length; i++)
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

            Console.WriteLine("\n Total sakinys:\n" + sentense );
            Console.ReadLine();





            #region

            int atsakymas = Compare();
            Console.WriteLine(atsakymas);


            double far = 0;
            double Celcjai = (far - 32) + (5 * 9);
            string a = Celcjai.ToString();
            Console.WriteLine(a);
            Console.WriteLine(a.ElementAt(1));
            decimal skaicius = 10;
            bool thisisabool = false;
            string kazkas = "kebabas"
            +"labas vakaras";
            string vardas = string.Empty;


            Console.WriteLine(kazkas);

            Console.WriteLine(Convert.ToString(thisisabool), "\nNorius atvaizduoti skaiciu {0}", skaicius);
            Console.WriteLine("labas vakaras \\ manovardas tdas");
            char nulis = '\r';
            Console.WriteLine(nulis);

            DateTime thisYear = new DateTime(2020, 4, 26);
            int teisigaArbaNe = DateTime.DaysInMonth(thisYear.Year, thisYear.Month);

            DateTime dabar = DateTime.Now;
            DateTime KeturiuValandosPridejimas = dabar.AddHours(4);
            Console.WriteLine(KeturiuValandosPridejimas);

            int year = DateTime.Now.Year;
            DayOfWeek dienaSavaiteje = DateTime.Now.DayOfWeek;

            TimeSpan time = dabar.TimeOfDay;

            TimeSpan SugalvotasDuration = new TimeSpan(2,4,24,13);   // laiko tarpas dvi dienos 4 valanods 24 min ir 13 sek
            DateTime isgalvotos = dabar.Add(SugalvotasDuration);

            Console.WriteLine(isgalvotos);


            Console.WriteLine(time);

            Console.WriteLine(year + "//" + dienaSavaiteje);

            Console.WriteLine(teisigaArbaNe);

            TimeSpan Valanda = new TimeSpan(1, 0, 0);
            DateTime ValandaPoDabar = dabar.Add(Valanda);
            Console.WriteLine(ValandaPoDabar);

            DateTime ValandaPriesDabar = dabar.Subtract(Valanda);
            Console.WriteLine(ValandaPriesDabar);
            Console.WriteLine(ValandaPriesDabar.GetType().ToString());


           

            int skaiciuss = 10;
            long ilgasSkaicius = (long)skaiciuss;

     

            var aString = "Hello C# 3.0";
            Console.WriteLine(aString);

          

            Student s1 = new Student();
            s1.Name = "Normanas";
            Student s2 = new Student();
            s2.Name = s1.Name;
            s2.Name = s1.Name.ToUpper();
            Console.WriteLine("s1 - " + s1.Name + " " + "s2 - " + s2.Name);


            Console.Read();

        }
        #endregion

        public static int Compare (string a, string b)
        {

           string n = "programing";
           string d = "Programing";
            if (a != b)
            {
                Console.WriteLine("teisingai");
                return 10;
            }

            if (n.Length > d.Length)
            {
                Console.WriteLine(1);
                return 1;
            }
            if (n.Length < d.Length)
            {
                Console.WriteLine(-1);
                return -1;
            }
            if (n.Length == d.Length)
            {
                Console.WriteLine(0);
                return 0;
            }

            return 0;

          

        }
    }
    public class Student
    {
        public string Name;
    }

   
}
