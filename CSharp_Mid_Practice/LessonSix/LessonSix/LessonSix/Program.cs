using System;
using System.Linq;

namespace LessonSix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Masyvai 

            string[] masyvas = new string[] { "as", "tu", "mes" };
            string[] data4 = { "Mano", "batai", "Mano", "buvo", "batai", "buvo", "buvo", "du", "." };

            ParamsTesting(15, 3.165, "vienas", 13, true, 'K');

            string[] input = pirmaUzduotis();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i]);
            }

            for (int i = input.Length - 1; i > -1; i--)
            {
                Console.Write(input[i]);

            }

            string[] data1 = { "Mano", "batai", "Mano", "buvo", "batai", "buvo", "buvo", "du", "." };

            string[] data2 = data1.ToArray();

            AntraUzduotis(data1);

            for (int i = 0; i < data1.Length; i++)
            {
                if (data1[i] != "!")
                {
                    Console.Write(data1[i] + " ");
                }
            }


            string laikinas = " ";
            string sauktukai = "";

            for (int i = 0; i < data1.Length; i++)
            {
                if (data1[i] != "!")
                {
                    laikinas += data1[i] + " ";
                }
                else if (data1[i] == "!")
                {
                    sauktukai += data1[i];
                }

            }

            Console.WriteLine("\n" + laikinas + sauktukai);

            Console.ReadKey();













            // nebaigta reikia padaryti, kad visi sauktukai atsidurtu gale.


            string[] arrr = ArrayReturn();

            for (int i = 0; i < arrr.Length; i++)
            {
                Console.Write(arrr[i]);
            }
            Console.WriteLine();

            for (int i = arrr.Length - 1; i > -1; i--)
            {
                Console.Write(arrr[i]);
            }

            Console.ReadLine();

            string[] data = { "Mano", "batai", "Mano", "buvo", "batai", "buvo", "buvo", "du", "." };
            task(data);

            string[] arr = new string[5] { "vienas", "du", "trys", "Keturi", "penki" };
            string[] arrCopy = new string[arr.Length];

            arrCopy = (string[])arr.Clone(); // arba nuadojant linq ToArray().

            // masyvus tik skaitykit , nebent reikia ji modifikuoti, bet tada pasidaryti kopija, kad negadinti originalo

            SpoilArray(arr);
            ArrayReferenceTest(arr);
            Console.ReadLine();

        }


        static void ParamsTesting(int x, double y, params object[] papildomi)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);

            if (papildomi.Length != 0)
            {
                foreach (var item in papildomi)
                {
                    Console.Write(item +" ");
                }
            }

            Console.ReadKey();
        }


        static string[] pirmaUzduotis()
        {

            string[] masyvas = new string[5];

            for (int i = 0; i < masyvas.Length; i++)
            {
                Console.WriteLine("Iveskite zodi: ");
                string inputString = Console.ReadLine();

                masyvas[i] = inputString;
            }

            return masyvas;

        }

        static void AntraUzduotis(string[] masyvas)
        {
            for (int i = 0; i < masyvas.Length; i++)
            {

                for (int j = i + 1; j < masyvas.Length; j++)
                {
                    if (masyvas[j] == masyvas[i])
                    {
                        masyvas[j] = "!";
                    }
                }
            }

            for (int i = 0; i < masyvas.Length; i++)
            {
                Console.WriteLine(masyvas[i]);

            }

        }























        static string[] ArrayReturn()
        {
            string[] array = new string[5];

            Console.WriteLine("Please write a word and press enter, till 5 words");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadLine();
            }

            return array;
        }

        // ANTRA UZDUOTIS
        static void task(string[] data)
        {


            for (int i = 0; i < data.Length; i++)
            {
                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[i] == data[j])
                    {
                        data[j] = "i";
                    }

                }
            }
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
        }


        // TRECIA UZDUOTIS 

        static void ArrayReferenceTest(string[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }

        static void SpoilArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = "-1";
            }
        }

    }
}
