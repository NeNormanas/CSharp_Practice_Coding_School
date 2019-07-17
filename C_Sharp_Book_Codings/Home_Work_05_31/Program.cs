using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Home_Work_05_31
{
    class Program
    {
        static void Main(string[] args)
        {

            //ComparingStrings();
            //Compare();
            //Exit();
            //SearchingString();

            //Console.WriteLine("Iveskite skaicius");
            //string zodis = Console.ReadLine();

            //bool atsakymas = ArVisiSkaiciai(zodis);
            //Console.WriteLine(atsakymas);
            //Console.ReadLine();

            //devideriai();
            //zodziuSujungimas();


            //IslygiavimaiOutputo();
            //replacingas();

            //StringBuilderis();
            //Operatoriai();
            //ciklai();
            //whilai();
            //arreys();
            //aeerys2();
            //listai();

            //KeyedArray ma = new KeyedArray(100);
            //ma["Bart"] = 8;
            //ma["Lisa"] = 10;
            //ma["Maggie"] = 2;

            //Console.WriteLine("Let's find Lisa's age");
            //int age = (int)ma["Lisal"];
            //Console.WriteLine("Lisa is {0} age", age);

            //PluralCollections();
            Dienos();


            Console.ReadLine();

            









        }
        public static void ComparingStrings()
        {
            string a = "programming";
            string b = "Programming";



            if (a == b)
            {
                bool atsakymas = true;
                Console.WriteLine(atsakymas);
            }
            if (a != b)
            {
                bool atsakymas = false;
                Console.WriteLine(atsakymas);
            }
            Console.ReadLine();

        }
        public static void Compare()
        {
            string a = "Normanas";
            string b = "Normanas";

            int results = 0; // jeigu rezultatas 1 - a>b, jeigu -1 b>a, jeigu 0 tai lygus.

            results = string.Compare(a, b);
            Console.WriteLine(results.ToString());
            Console.ReadLine();

        }
        public static void Exit()
        {
            Console.WriteLine("Each line you enter will be"
                        + "added to a sentence until you"
                        + "enter EXIT or QUIT");
            string sentense = "";

            for (int i = 1; i > sentense.Length; i++)
            {
                Console.WriteLine("Enter a string");
                string line = Console.ReadLine();
                string[] terms = { "EXIT", "exit", "QUIT", "quit" };
                bool iseiti = false;
                foreach (string item in terms)
                {
                    if (string.Compare(line, item) == 0)
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

        public static void SearchingString()

        {
            string spalva = "Geltona";

            int kelintasIndeksas = spalva.IndexOf('t'); // surandame kelintas inkestas yra simbolis t
            Console.WriteLine(kelintasIndeksas);


            char[] ieskomiSimboliai = { 'a', 'b', 'c' };
            int pirmasisRastas = spalva.IndexOfAny(ieskomiSimboliai); // pirmas rastas is saraso
            Console.WriteLine(pirmasisRastas);

            if (spalva.Contains("ltro")) // patikrina ar zodyje yra toks junginys
            {
                Console.WriteLine(true);

            }
            string sub = spalva.Substring(3); // nukerta nuo 0 iki 2 imtinai
            Console.WriteLine(sub);

            bool nera = string.IsNullOrEmpty(spalva);
            Console.WriteLine(nera); // patikrina ar stringas nera tuscias

            string zodisTriminimui = "***][labas**--";
            string baltitarpai = "   labas     ";
            char[] simboliai = { '*', ']', '[', '-' };
            string triminimas = zodisTriminimui.Trim(simboliai); // apkirps pagal simboliai sarasa, juos ismes lauk
            string beBaltutarpu = baltitarpai.Trim(); // NUIMA BALTUS TARPUS NUO GALO IR PRIEKIO
            string galotriminimas = baltitarpai.TrimEnd();
            Console.WriteLine(triminimas + beBaltutarpu + galotriminimas); // nutrina baltus tarpus tik nuo galo.



            Console.ReadLine();
        }
        public static bool ArVisiSkaiciai(string zodis) // patikriname ar ivestas zodis yra skaicius
        {
            string zodisnutrimintas = zodis.Trim();

            if (zodisnutrimintas.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < zodisnutrimintas.Length; i++)
            {
                if (char.IsDigit(zodisnutrimintas[i]) == false)
                {
                    return false;

                }
            }

            return true;




        }

        public static void devideriai() // atskiria sakinyje zodzius, tada suranda kurie yra skaiciai ir atspauzdina ju suma
        {
            Console.WriteLine("Iveskite zodzius");
            string input = Console.ReadLine();

            char[] deviders = { ',', ' ' };

            string[] isskaidyta = input.Split(deviders);
            int sum = 0;
            foreach (var item in isskaidyta)
            {
                if (item.Length > 0)
                {
                    if (ArVisiSkaiciai(item))
                    {
                        int numeris = 0;
                        if (Int32.TryParse(item, out numeris))
                        {
                            Console.WriteLine("Kitas skaicius = {0}", numeris);
                            sum += numeris;
                        }
                    }
                }

            }
            Console.WriteLine(sum);
            Console.ReadLine();

        }

        public static void zodziuSujungimas()
        {
            string[] sakinys = { "Jonas", "Antanas", "Juozas", "Kestas" };
            string sulipdytas = string.Join("-", sakinys);
            Console.WriteLine(sulipdytas);

        }


        public static void IslygiavimaiOutputo()
        {
            List<string> vardai = new List<string> { "Kristina   ", "   Sara", "Ona" };
            foreach (var item in vardai)
            {
                Console.WriteLine("Pries: {0}", item);

            }

            List<string> sulyiuota = new List<string>();
            for (int i = 0; i < vardai.Count; i++)
            {
                string nutriminti = vardai[i].Trim();
                sulyiuota.Add(nutriminti);
            }
            int maxIlgis = 0;
            foreach (var item in sulyiuota)
            {
                if (item.Length > maxIlgis)
                {
                    maxIlgis = item.Length;
                }

            }
            for (int i = 0; i < sulyiuota.Count; i++)
            {
                sulyiuota[i] = sulyiuota[i].PadRight(maxIlgis + 1);

            }
            foreach (var item in sulyiuota)
            {
                Console.WriteLine("Po: {0}", item);
            }
            Console.ReadLine();
        }

        public static void replacingas()
        {
            string zodis = "Labas ! vakaras";
            string pakeistas = zodis.Replace('!', '?');
            Console.WriteLine(pakeistas);

            char[] whitespace = { ' ', '\n', '\t' };
            string s = " this is a \nstring";
            Console.WriteLine("preis: " + s);

            string[] segmentai = s.Split(whitespace);
            string isvedimas = "";
            foreach (var item in segmentai)
            {
                isvedimas = string.Concat(isvedimas, item);

            }
            Console.WriteLine("pirmojo budu: {0}", isvedimas);

            // ANTRAS BUDAS 

            for (int i = 0; i < whitespace.Length; i++)
            {
                int offset = s.IndexOfAny(whitespace);

                if (offset == -1)
                {
                    break;

                }
                string before = s.Substring(0, offset);
                string after = s.Substring(offset + 1);
                s = string.Concat(before, after);


            }
            Console.WriteLine("Antruoju budu" + ":" + s);

        }

        // 2019-06-06 

        public static void StringBuilderis()
        {
            string pirmas = "Rapid";
            string antras = pirmas + "ly";
            Console.WriteLine(antras);

            StringBuilder builderis = new StringBuilder("012");
            builderis.Append("34");
            builderis.Append("56");
            string rezult = builderis.ToString(); // stringbuilder prideda zodzius
            Console.WriteLine(rezult);

            StringBuilder builderiukas = new StringBuilder(); //automatskai 16 charakteriu
            StringBuilder bildeirs = new StringBuilder(256); // talpina 256 charakterisu


            StringBuilder sb = new StringBuilder(20000);
            for (int i = 0; i < 1000; i++)
            {
                //sb.Append(sarasas[i])  -- tada visa 1000 charakteriu ilgio sarasa sulipdys i rezultatas

            }
            string rezultatas = sb.ToString();


            // padaryti pirmaja raide is didziosios

            StringBuilder sbb = new StringBuilder("normanas");
            sbb[0] = char.ToUpper(sbb[0]);
            string isdidziosios = sbb.ToString();
            Console.WriteLine(isdidziosios); // nuo sion normanas yra Normanas.
        }



        public static void Operatoriai()
        {
            int n = -5;
            int m = 5;
            int rezult = n + m; // rezult  = 0

            int a;
            a = 1;
            int b = ++a;

            a = 1;
            int d = a++;


            Console.WriteLine(b + "" + d); // b rodo 2, o d rodo 1.

            float f1;
            float f2;
            f1 = 10;
            f2 = f1 / 3;
            bool b1 = (3 * f2) == f1; // FLASE 

            f1 = 9;
            f2 = f1 / 3;
            bool b2 = (f2 * 3) == f1; // TRUE

            Console.WriteLine("{0}, {1}", b1, b2);






        }

        public static void ciklai()
        {


            Console.WriteLine("Enter a source Principal: ");
            string Ivedimas = Console.ReadLine();

            decimal principal = Convert.ToDecimal(Ivedimas);

            if (principal < 0)
            {
                Console.WriteLine("Bad input, cannot be negative!");

            }
            Console.WriteLine("Enter interest");
            string Interestivedimas = Console.ReadLine();
            decimal interest = Convert.ToDecimal(Interestivedimas);
            if (interest < 0)
            {
                Console.WriteLine("Bad input, cannot be negative!");
                interest = 0;

            }
            decimal interestPaid = principal * (interest / 100);
            decimal total = principal + interestPaid;
            Console.WriteLine();
            Console.WriteLine("Principal    =" + principal);
            Console.WriteLine("Ineterst     =" + interest + "%");
            Console.WriteLine();
            Console.WriteLine("Ineterest paid = " + interestPaid);
            Console.WriteLine("Total        =" + total);


            int maximumInterest = 50;
            Console.WriteLine("Enter a source Principal: ");
            string Ivedimas2 = Console.ReadLine();
            decimal principal2 = Convert.ToDecimal(Ivedimas2);
            if (principal2 < 0)
            {
                Console.WriteLine("error, it is negative");
            }
            else
            {
                Console.WriteLine("enter interest");
                string interestInput = Console.ReadLine();
                decimal interestt = Convert.ToDecimal(interestInput);

                if (interestt < 0 || interestt > maximumInterest)
                {

                    Console.WriteLine("interest cannot be negative /nor greater than" + maximumInterest);
                    interestt = 0;
                }
                else
                {
                    Console.WriteLine("Enter number of year");
                    int duration = Convert.ToInt32(Console.ReadLine());

                    decimal interestpaid;
                    interestpaid = principal2 + (interestt / 100);
                    decimal totall = principal2 + interestpaid;
                    Console.WriteLine();
                    Console.WriteLine("Principal    =" + principal2);
                    Console.WriteLine("Ineterst     =" + interestt + "%");
                    Console.WriteLine("Duration     =" + duration + "years");

                    int year = 1;
                    while (year <= duration)
                    {
                        decimal interestPaidd;
                        interestPaidd = principal2 * (interestt / 100);
                        principal2 = principal2 + interestPaidd;
                        principal2 = decimal.Round(principal2, 5); // round tai kiek matysis skaiciu po kablelio
                        Console.WriteLine(year + "-" + principal2);
                        year = ++year;
                    }


                }
            }





        }
        // 2019-06-07
        public static void switchai()
        {
            // galima daryti ir su if'ais
            int maritalstatus = Convert.ToInt32(Console.ReadLine());

            if (maritalstatus == 0)
            {
                // unmerried
            }
            else
            {
                if (maritalstatus == 1)
                {
                    //must be married...
                }
            }

            switch (maritalstatus) // argumentas gali buti ir string tipo
            {
                case 0:
                    Console.WriteLine("non merried");
                    break;
                case 1:// galima daryti kelis keisus iki break 
                case 2:
                    Console.WriteLine("merried arba jau issiskyres");
                    break;
                default:
                    break;
            }
        }

        public static void whilai()
        {
            int maximumInterest = 50;
            decimal principal;

            while (true)
            {
                Console.WriteLine("Enter a principal");
                principal = Convert.ToDecimal(Console.ReadLine());

                if (principal >= 0)
                {
                    break;
                }
                Console.WriteLine("Principal cannot be negative");
                Console.WriteLine("Try again");

            }
            decimal ineterest;
            while (true)
            {
                Console.WriteLine("enter interest:");
                ineterest = Convert.ToDecimal(Console.ReadLine());

                if (ineterest >= 0 && ineterest <= maximumInterest)
                {
                    break;
                }
                Console.WriteLine("Interest cannot be negative and greater then" + maximumInterest);
                Console.WriteLine("try again");

            }

            Console.WriteLine("Enter a number of years:");
            int duration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Principal = " + principal);
            Console.WriteLine("Interest = " + ineterest + "%");
            Console.WriteLine("Duration = " + duration + "years");

            int year = 1;
            while (year <= duration)
            {
                decimal interestpaid;
                interestpaid = principal * (ineterest / 100);
                principal = principal + interestpaid;
                principal = decimal.Round(principal, 2);
                Console.WriteLine(year + "-" + principal);
                ++year;



            }
        }
        public static void arreys()
        {
            double[] doublearrays = { 5, 2, 7, 5, 6, 5, 4, 2, 5, 3 };
            double[] emptyarray = new double[6]; // tuscias 6 vietu sarasas

            double sum = 0;

            for (int i = 0; i < 10; i++)
            {
                sum = sum + doublearrays[i];
            }
            double average = sum / 10;
            Console.WriteLine(average);
        }
        public static void aeerys2()
        {
            Console.WriteLine("Enter a numbers of values to average:");
            int numElements = Convert.ToInt32(Console.ReadLine());
            double[] doublesArray = new double[numElements]; // bus dydis toks kiek ivedei skaiciu
            for (int i = 0; i < numElements; i++)
            {
                Console.WriteLine("enter double #" + (i + 1) + ": ");
                double value = Convert.ToDouble(Console.ReadLine());
                doublesArray[i] = value;
            }
            double sum = 0;
            for (int i = 0; i < numElements; i++)
            {
                sum = sum + doublesArray[i];
            }
            double average = sum / numElements;
            Console.WriteLine();
            Console.Write(average + " is the average of (" + doublesArray[0]);
            for (int i = 0; i < numElements; i++)
            {
                Console.Write(" + " + doublesArray[i]);
            }
            Console.WriteLine(") / " + numElements);

            Console.WriteLine("The 5 planets closest to the sum, in order: ");
            string[] planets = new string[] { "Mercury", "Venus", "Earth", "Mars", "Jupiter" };
            foreach (var item in planets)
            {
                Console.WriteLine("\t" + item);
            }
            Console.WriteLine("\nNow listed alphabetically: ");
            string[] sortedNames = planets;
            Array.Sort(sortedNames);

            foreach (var item in sortedNames)
            {
                Console.WriteLine("\t" + item);
            }
            Console.WriteLine("\nList by name Lenght - shortest first: ");
            int outer;
            int inner;
            for (outer = planets.Length - 1; outer >= 0; outer--)
            {
                for (inner = 1; inner <= outer; inner++)
                {
                    if (planets[inner - 1].Length > planets[inner].Length)
                    {
                        string temp = planets[inner - 1];
                        planets[inner - 1] = planets[inner];
                        planets[inner] = temp;
                    }

                }
            }

            foreach (var item in planets)
            {
                Console.WriteLine("\t" + item);

            }


            Console.WriteLine("\nNow listed longest first: ");
            for (int i = planets.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("\t" + planets[i]);

            }
        }
        public static void listai()
        {
            List<int> intList = new List<int>();
            List<string> mymp3 = new List<string>();
            mymp3.Add("one");



            string[] myMp3 = new string[50];

            List<int> inttList = new List<int>();
            inttList.Add(3);
            inttList.Add(4);
            foreach (var item in inttList)
            {
                Console.WriteLine(item);
            }

            List<string> vardai = new List<string>();
            string vardas1 = "jonas";
            string vardas2 = "kazys";

            vardai.Add(vardas1);
            vardai.Add(vardas2);

            String[] studentai = { "Max", "JOnas" };

            vardai.AddRange(studentai);
            Console.WriteLine("num students in student List:" + vardai.Count);


            String[] student = studentai.ToArray();

            Console.WriteLine(student.Length);
            Console.WriteLine("Student2 at" + vardai.IndexOf(vardas2));

            vardai.RemoveAt(1);
            vardai.Insert(1, "Normanas");
            Console.WriteLine(vardai[1]);

            // DICTIONARY

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("C#", "cool");

            Console.WriteLine("Contains key C# " + dict.ContainsKey("C#"));
            foreach (KeyValuePair<string, string> pair in dict)
            {
                Console.WriteLine("Key: " + pair.Key.PadRight(8) + "Value: " + pair.Value);
            }
            Dictionary<string, string>.KeyCollection keys = dict.Keys;
            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }
            Dictionary<string, string>.ValueCollection values = dict.Values;
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
            // HASH SET 
            //naudojame kai sarase nebutu vienodu reisksmiu

            HashSet<int> numeriai = new HashSet<int>();
            numeriai.Add(1);
            numeriai.Add(5);

            // or
            HashSet<int> numeriai2 = new HashSet<int> { 1, 55, 6, 7, 5 };

            // or 

            List<int> skaiciai = new List<int> { 1, 5, 6, 45, 4 };
            HashSet<int> numeriai3 = new HashSet<int>(skaiciai);
            skaiciai.Add(5);

            foreach (var item in skaiciai)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Combining two collections wtih no dublicates:");
            List<string> colors = new List<string> { "red", "yellow", "orange" };
            string[] moreColors = { "orange", "yellow", "green", "blue", "violet" };
            HashSet<string> combined = new HashSet<string>(colors);
            combined.UnionWith(moreColors);
            foreach (var item in combined)

            {
                Console.WriteLine(item);
            }
            List<string> spectrum = new List<string>(combined);

            Console.WriteLine("finding the overlap in two lists");
            List<string> prezidencialCandidates = new List<string> { "Clinton", "Edwards", "Giuliani", "McCain", "Obama", "Romney" };
            List<string> senators = new List<string> { "Alexander", "Boxer", "Clinton", "McCain", "Obama", "Snowe" };
            HashSet<string> senatorsRunning = new HashSet<string>(prezidencialCandidates);
            senatorsRunning.IntersectWith(senators);
            foreach (var item in senatorsRunning)
            {
                Console.WriteLine(item);
            }
            // Exclude atspauzdins tik nepasikartojancius dviejuose sarasuose
            Console.WriteLine("Excluding items from a list");
            Queue<int> queue = new Queue<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 17 });
            HashSet<int> unique = new HashSet<int> { 1, 3, 5, 7, 9, 11, 13, 15 };
            unique.ExceptWith(queue);
            foreach (var item in unique)
            {
                Console.WriteLine(item);// lieka tik 11,13,15.
            }

            Console.WriteLine("Finding just non-overlapping items in two lists"); // tie kurie nepasikartojantys abiejuose sarasuose
            Stack<int> stackOne = new Stack<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
            Stack<int> stackTwo = new Stack<int>(new int[] { 2, 4, 6, 7, 8, 10, 12 });
            HashSet<int> nonoverlapping = new HashSet<int>(stackOne);
            nonoverlapping.SymmetricExceptWith(stackTwo);
            foreach (var item in nonoverlapping)
            {
                Console.WriteLine(item); // 5, 3, 1, 12, 10
            }
        }

        // An indexer program example


        public static void PluralCollections()
        {
            // Masyvai ARRAY
            string[] dayOfTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            foreach (var day in dayOfTheWeek)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine("Which day do you want to display?");
            Console.WriteLine("(Monday = 1, etc. > ");
            int iDay = int.Parse(Console.ReadLine());

            string chosenDay = dayOfTheWeek[iDay - 1];
            Console.WriteLine("That day is {0}", chosenDay);

            dayOfTheWeek[2] = dayOfTheWeek[2].Replace(dayOfTheWeek[2], "Zodis");
            Console.WriteLine(dayOfTheWeek[2]);

            string zodis = dayOfTheWeek[1];
            Console.WriteLine(zodis);

            int i = 1;
            foreach (var item in dayOfTheWeek)
            {

                Console.WriteLine(i + "." + item);
                i++;
            }

            // Sarasas LIST<T>

            List<string> daysOfWeek = new List<string>
            {
                "Monday",
                "Tuesday",
                "Wednesday" ,
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };


            // or daysOfWeek.Add("Monday");


            List<string> Vardai = new List<string> { };

            Vardai.Add("Normanas");


        }
        public static void Dienos()
        {
            string[] Dienos = {"Pirmadienis", "Antradienis", "Treciadienis",
            "ketvirtadienis", "Penktadienis", "Sestadienis", "Sekmadienis"};

            foreach (var item in Dienos)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        

        
        


        public class KeyedArray
        {
            private string[] _keys;
            private object[] _arrayElements;
            public KeyedArray(int size)
            {
                _keys = new string[size];
                _arrayElements = new object[size];

            }
            private int Find(string targetKey)
            {
                for (int i = 0; i < _keys.Length; i++)
                {
                    if (string.Compare(_keys[i], targetKey) == 0)
                    {
                        return i;
                    }
                }
                return -1;
            }

            private int FindEmpty()
            {
                for (int i = 0; i < _keys.Length; i++)
                {
                    if (_keys[i] == null)
                    {
                        return i;
                    }
                }
                throw new Exception("Array is full");
            }

            public object this[string key]
            {
                set
                {
                    int index = Find(key);
                    if (index < 0)
                    {
                        index = FindEmpty();
                        _keys[index] = key;
                    }
                    _arrayElements[index] = value;
                }
                get
                {
                    int index = Find(key);
                    if (index < 0)
                    {
                        return null;
                    }
                    return _arrayElements[index];

                }
            }

        }

    }

}






