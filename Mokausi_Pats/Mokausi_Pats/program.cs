using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokausi_Pats
{
    class Program
    {
        static void Main(string[] args)
        {

            operatoriai();
           //////////////////
            string[] broliai = { "Jonas", "Antanas", "Zilvinas" };
            string borliaisujungti = string.Join(" ", broliai);
            Console.WriteLine(borliaisujungti);

            

            ///////////////

            Console.WriteLine("Iveskite integer skaiciu: ");
            string ivedimas = Console.ReadLine();
            if (!ArYraskaiciutikrinimas(ivedimas))
            {
                Console.WriteLine("Ivedete ne skaicius, deje...");
            }
            else
            {
                int ivedimasPataisytas = Convert.ToInt32(ivedimas);

                Console.WriteLine("Puiku, jus ivedetesiuos skaicius {0}", ivedimasPataisytas);
            }

            /////////////////////
            Console.WriteLine("Each line you enter will be"
                        + "added to a sentence until you"
                        + "enter EXIT or QUIT");

            string sentense = "";
            string[] IsejimoSarasas = { "EXIT", "exit", "QUIT", "quit" };
            int j = 0;
            while (j <= sentense.Length)
            {
                Console.WriteLine("Iveskite zodi arba sakini: ");
                string IvestasSakinys = Console.ReadLine();
                string pakeltas = IvestasSakinys.ToUpper();
                j++;

                bool iseiti = false;

                foreach (string item in IsejimoSarasas)
                {
                    if (string.Compare(pakeltas, item) == 0)
                    {
                        iseiti = true;
                    }
                }


                if (iseiti == true)
                {
                    break;
                }


                sentense = string.Concat(sentense, pakeltas);
                Console.WriteLine("\n Jus ivedete:" + sentense);

            }

            Console.WriteLine("\nTotal sakinys:\n" + sentense);
            Console.ReadLine();


            ////////////////////////////
            string Vardas = "normanas";
            string TeisingasVardas = char.ToUpper(Vardas[0]).ToString() + Vardas.Substring(1, Vardas.Length - 1);
            Console.WriteLine(TeisingasVardas);

            Console.ReadLine();

            string maistas = "*Kebabas*";


            char[] sarasas = { '*' };
            string Nukirpta = maistas.Trim(sarasas);
            Console.WriteLine(Nukirpta);

            foreach (char asimboliai in maistas)
            {
                Console.WriteLine(asimboliai);
            }

            Console.ReadLine();


            int startIndex = 0;
            char[] ch = { 'b' };

            int kelintassimbolis = maistas.IndexOfAny(ch, startIndex);


            Console.WriteLine(kelintassimbolis);
            Console.ReadLine();

            bool artuscias = string.IsNullOrEmpty(maistas);
            Console.WriteLine(artuscias);
//////////////////////////////
///

            bool atsakymas = ArYraskaiciutikrinimas("Kebabas");
            Console.WriteLine(atsakymas);

            Console.ReadLine();


        }
        public static bool ArYraskaiciutikrinimas(string zalias) // patikriname ar ivestame zodyje yra skaiciu, jeigu nera ismeta "True"
        {
            string zodis = zalias.Trim(); // nukerpu kad is abieju pusiu prasidetu iskarto simboliai

            if (zodis.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < zodis.Length; i++)
            {
                if (char.IsDigit(zodis[i]) == false)
                {
                    return false;
                }
            }
            return true;



        }
        public static void StringoIskarpymas()
        {
            Console.WriteLine("Iveskite skaicius atskirtus per kableli");
            string IvetstiSKaiciai = Console.ReadLine();

            char[] deviders = { ',', ' ' };
            string[] segmentai = IvetstiSKaiciai.Split(deviders);
            int sum = 0; ;
            foreach (var item in segmentai)
            {

                if (item.Length > 0)
                {
                    if (ArYraskaiciutikrinimas(item))
                    {
                        int numeris = 0;
                        if (Int32.TryParse(item, out numeris))
                        {
                            Console.WriteLine("Next number = {0}", numeris);
                            sum += numeris;
                        }
                    }
                }
            }
            Console.WriteLine("sum = {0}", sum);
            Console.ReadLine();
        }
        public static void simboliuPridejimas()
        {
            List<string> vardai = new List<string> { "   Normanas", "Ugnelukkkkkk   ", "   Marta   " };

            foreach (var item in vardai)
            {
                Console.WriteLine("tai vardai:'" + item + "' visu zmoniu");
            }

            List<string> vardaisupriedais = new List<string>();


            for (int i = 0; i < vardai.Count; i++)
            {
                string PakeistasVardas = vardai[i].Trim();
                vardaisupriedais.Add(PakeistasVardas);



            }
            int maxLenght = 0;
            foreach (var item in vardaisupriedais)
            {
                if (item.Length > maxLenght)
                {
                    maxLenght = item.Length;
                }
            }

            for (int i = 0; i < vardaisupriedais.Count; i++)
            {
                vardaisupriedais[i] = vardaisupriedais[i].PadRight(maxLenght + 1);
            }

            Console.WriteLine("Normalus vardai");

            foreach (var item in vardaisupriedais)
            {
                Console.WriteLine("Visi varadai" + item + "Vardeliai");
            }
            Console.ReadLine();

        }// Sutvarko stringus kad butu vienodo ilgio uzimant langelius bei sulygiuoja i desine puse
        public static void replacingas()
        {
            string vardas = "NormaN" +
                "nas";
            Console.WriteLine(vardas.Replace('N', '*'));
        }
        public static void SilipdymasisSubStringu() // padaro kad sakinys pvz nebeturetu tarpu ar perkelimu ar kitu simbolius ir tada juos sulibdo i viena sakini
        {
            char[] whiteSpace = { ' ', '\n', '\t' };
            string sakinys = "Tai yra \nZodis";
            Console.WriteLine("Before: " + sakinys);

            // PIRMAS BUDAS
            string[] segmentai = sakinys.Split(whiteSpace);
            string Isvedimas = "";

            foreach (var item in segmentai)
            {
                Isvedimas = String.Concat(Isvedimas, item);

            }
            Console.WriteLine("Pirmuoju budu atsakymas:  " + Isvedimas);

            //ANTRAS BUDAS

            for (int i = 0; i < whiteSpace.Length; i++)
            {
                int offset = sakinys.IndexOfAny(whiteSpace);


                if (offset == -1)
                {
                    break;
                }

                string before = sakinys.Substring(0, offset);
                string after = sakinys.Substring(offset + 1);
                sakinys = String.Concat(before, after);

            }
            Console.WriteLine("Antruoju budu atsakymas" +
                ": " + sakinys);
        }
        public static void spauzdinimoBudai() // VALIUTOS SPAUZDINIMAS SU 93 PSL.
        {
            int skaicius = 1;
            for (int i = 0; i < skaicius; i++)
            {
                Console.WriteLine("iveskite double skaiciu");
                string Input = Console.ReadLine();

                if (Input.Length == 0)
                {
                    break;
                }

                double invedimas = double.Parse(Input);// konvertuojame string i double

                Console.WriteLine("iveskite skaicius atskirtus tarpais");

                char[] skirtukas = { ' ' }; // sukuriu skirtuka

                string FormatuojamasTekstas = Console.ReadLine();

                string[] format = FormatuojamasTekstas.Split(skirtukas);

                foreach (var item in format)
                {
                    if (item.Length != 0)
                    {
                        string formatCommand = "{0:" + item + "}";
                        Console.WriteLine("Formatuojama {0}", formatCommand);
                        Console.WriteLine(formatCommand, invedimas);
                    }
                }

                Console.WriteLine();


            }
        }
        public static void stingopridejimas()
        {
            string A = "Norma";
            string B = A + "nas";
            string C = "nas" + A;

            Console.WriteLine(C);

            // sarase esanciu string sujungimas i viena stinga

            string[] sarasas = { "normanas", "normanas", "normanas", "normanas", "normanas" };
            string sakinys = string.Empty;
            for (int i = 0; i < sarasas.Length; i++)
            {
                sakinys = sakinys + sarasas[i];

            }
            Console.WriteLine(sakinys);


            // STRING BUILDERIS

            StringBuilder naujas = new StringBuilder(); // sklaustuose galima nurodyti kiek talpins charteriu, by defoltu duoda 16
            naujas.Append("Kebabas");
            naujas.Append("ceburekas");
            naujas.Append("ceburekas");
            naujas.Append("ceburekas");


            Console.WriteLine(naujas); // atspauzdins viska i vien eilute

            //pridejimas i gala su builderiu   2 budas realiai  

            StringBuilder bilderis = new StringBuilder();
            
           

            for (int i = 0; i < naujas.Length; i++)
            {
                bilderis.Append(naujas[i]);
            }
            string rezult = bilderis.ToString();
            Console.WriteLine(rezult);


            // dar vienas triukas su pirmos rades padarymu i uppercasa

            StringBuilder ManoVardas = new StringBuilder("normanas");
            ManoVardas[0] = char.ToUpper(ManoVardas[0]);
            string pataisytas = ManoVardas.ToString();
            Console.WriteLine(pataisytas);
        }

        // chapter 4, OPERATORIAI
        public static void operatoriai()
        {
            int A = 5;
            int B = -A;
            Console.WriteLine(A +" " +B);
            

         
            A = B = 18;
            A++; // pakelimas vienetu
            ++B; // pakelimas vienetu
            Console.WriteLine(A +" " + B);

            // skaiciai kurie nesidalina ir  nors karta padalinai ir bandai atgal garzinti yra jau FALSE
            float F1;
            float F2;
            F1 = 10;
            F2 = F1 / 3; 
            bool b1 = (3 * F2) == F1;
            Console.WriteLine(b1);

            // skaiciai kurie dalinasi lieka true
            F1 = 12;
            F2 = F1 / 3;
            bool b2 = (3 * F2) == F1;
            Console.WriteLine(b2);
            Console.ReadLine();
        }


        



         
        

    }
}





