using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            
             //Lesson One pratesimas 

             //sukeisti a su b reiksme 

            int a = 10;
            int b = 13;

            int c = a;

            a = b;
            b = c;

            Console.WriteLine(a + " " + b);

            Console.ReadLine();

          //  Lesson two

            int vienas = 10;
            int du = 15;

            int liekana = vienas % du;

            Console.WriteLine(liekana); // atsakymas 10
            Console.Clear();


           //  Uzdavinys nr.1

            Console.WriteLine("Iveskite apskritimo spinduli:");
            double input = Convert.ToDouble(Console.ReadLine());
            double ilgis = input * 2;
            double plotas = Math.PI * Math.Pow(input, 2);
            Console.WriteLine($"Ilgis: {ilgis}, plotas {plotas}");



            Console.WriteLine("Iveskite atstuma metrais: ");
            double atstumas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite laika (sekundemis): ");
            double sekundes = Convert.ToDouble(Console.ReadLine());
            double kmH = (atstumas / 1000) / (sekundes / 3600);
            Console.WriteLine(kmH + " KM/H");




          //   Uzdavinys nr. 2 

            int number = 10;
            number += 20;
            int updatedNumber = number += 20;
            updatedNumber /= 10;
            Console.WriteLine(updatedNumber);

            updatedNumber++;


            // Uzdavinys nr. 3 


            Console.WriteLine("\nPlease write a number: ");
            double inputOne = double.Parse(Console.ReadLine());
            Console.WriteLine("Please write a second number: ");
            double inputTwo = double.Parse(Console.ReadLine());


            if (inputOne.Equals(inputTwo))
            {
                Console.WriteLine(inputOne + " Is equals to " + inputTwo);

            }
            else
            {
                Console.WriteLine(inputOne + " Is not equals to " + inputTwo);
            }

            if (inputOne > inputTwo)
            {
                Console.WriteLine(inputOne + " is greater than " + inputTwo);
            }
            else if (inputOne < inputTwo)
            {
                Console.WriteLine(inputOne + " is smaller than " + inputTwo);
            }
            if (inputOne <= inputTwo)
            {
                Console.WriteLine(inputOne + " is smaller or equals to " + inputTwo);
            }
            else if (inputOne >= inputTwo)
            {
                Console.WriteLine(inputOne + " is greater or equals to " + inputTwo);
            }


           //  Uzdavinys nr. 4

            Console.WriteLine("\nPlease write your age: ");
            int inputas = Int32.Parse(Console.ReadLine());

            if (inputas >= 18)
            {
                Console.WriteLine("Yes, your age is 18 or more years");

            }
            else
            {
                Console.WriteLine("No, your age is under 18");

            }

            if (inputas % 2 == 0)
            {
                Console.WriteLine("Yes, jusu amzius yra lyginis");
            }
            else
            {
                Console.WriteLine("No, jusu amzius nera lyginis");
            }

           //  Uzdavinys nr. 5 


            Console.WriteLine("\nParasykite savo pazymi: ");

            var pazimys = Console.ReadLine();
            int Pazymioivedimas;

            if (Int32.TryParse(pazimys, out Pazymioivedimas))
            {
                if (Pazymioivedimas > 0 && Pazymioivedimas <= 10)
                {
                    if (Pazymioivedimas == 10)
                    {
                        Console.WriteLine("Puiku {0}", Pazymioivedimas);
                    }
                    else if (Pazymioivedimas == 9 || Pazymioivedimas == 8)
                    {
                        Console.WriteLine("Labai gerai {0}", Pazymioivedimas);
                    }
                    else if (Pazymioivedimas == 7 || Pazymioivedimas == 6)
                    {
                        Console.WriteLine("Gerai {0}", Pazymioivedimas);
                    }
                    else if (Pazymioivedimas == 5)
                    {
                        Console.WriteLine("Vidutiniskai {0}", Pazymioivedimas);
                    }
                    else if (Pazymioivedimas == 4)
                    {
                        Console.WriteLine("Bent teigiamas {0}", Pazymioivedimas);
                    }
                    else if (Pazymioivedimas == 3 || Pazymioivedimas == 2 || Pazymioivedimas == 1)
                    {
                        Console.WriteLine("Labai blogai {0}", Pazymioivedimas);
                    }

                }
                else
                {
                    Console.WriteLine("Blogas rezis");
                }

            }
            else
            {
                Console.WriteLine("Ivedete ne skaiciu!");
            }

          //   Uzdavinys nr. 6 

            Console.WriteLine("\nPlease write first number: ");
            int firstNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease write second number: ");
            int SecondNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease write third number: ");
            int thirdNumber = Int32.Parse(Console.ReadLine());


            if (firstNumber > SecondNumber && firstNumber < 100)
            {
                Console.WriteLine(" 1 salyga: True");

            }
            else
            {
                Console.WriteLine(" 1 salyga: False");
            }


            if (SecondNumber > 0 && SecondNumber > firstNumber)
            {
                Console.WriteLine(" 2 salyga: True");

            }
            else
            {
                Console.WriteLine(" 2 salyga: False");
            }


            if (firstNumber > SecondNumber && firstNumber > thirdNumber || firstNumber >= 0)
            {
                Console.WriteLine(" 3 salyga: True");

            }
            else
            {
                Console.WriteLine(" 3 salyga: False");
            }

            if (thirdNumber >= 5 && thirdNumber <= 10 || thirdNumber > firstNumber || thirdNumber > SecondNumber)
            {
                Console.WriteLine(" 4 salyga: True");

            }
            else
            {
                Console.WriteLine(" 4 salyga: False");
            }

           //  TERNARY OPERATOR


            int something = 20;
            int nothing = 10;


            Console.WriteLine(nothing <= something ? something++ : something--); // PVZ
            int newValue = nothing <= something ? something++ : something--;  // PVZ 2 


            nothing = nothing > something ? nothing + 100 : nothing -200;

            Console.WriteLine(nothing);
            

          //  Uzduotis su Switch

            Console.WriteLine("\nIveskite tris skaicius: ");
            var ivedimas = Console.ReadLine();
            int skaicius;

            if (Int32.TryParse(ivedimas, out skaicius))
            {
                if (Enumerable.Range(100, 999).Contains(skaicius))
                {
                    int pirmasSk = skaicius / 100;
                    int antrasSk = skaicius % 100 / 10;
                    int treciasSk = skaicius % 10;

                    switch (pirmasSk)
                    {
                        case 1:
                            Console.WriteLine(pirmasSk + antrasSk + treciasSk);
                            break;
                        case 2:
                            Console.WriteLine(pirmasSk - treciasSk);
                            break;
                        case 3:
                            Console.WriteLine(antrasSk * treciasSk);
                            break;
                        default:
                            break;
                    }


                }
                else
                {
                    Console.WriteLine("Out of requared range, must be 100 up to 999 !");
                }
            }
            else
            {
                Console.WriteLine("Ivedete ne skaiciu!");
            }

            // Papildoma uzduotis - Kavos aparatas

            Console.WriteLine("\nIveskite norima gerimo numeri:  ");
            Console.WriteLine("\n1 - Limonadas");
            Console.WriteLine("2 - arbata");
            Console.WriteLine("3 - kakava");
            Console.WriteLine("4 - kava");
            Console.WriteLine("5 - nieko");

            var gerimoIvedimas = Console.ReadLine();

            int numeris;

            string pasirinkimoPavadinimas;

            if (Int32.TryParse(gerimoIvedimas, out numeris))
            {

                if (Enumerable.Range(1, 5).Contains(numeris))
                {
                    switch (numeris)
                    {
                        case 1:
                            pasirinkimoPavadinimas = "limonada";
                            break;
                        case 2:
                            pasirinkimoPavadinimas = "arbata";
                            break;
                        case 3:
                            pasirinkimoPavadinimas = "kakava";
                            break;
                        case 4:
                            pasirinkimoPavadinimas = "kava";
                            break;
                        case 5:
                            pasirinkimoPavadinimas = "nieko";
                            break;

                        default:
                            pasirinkimoPavadinimas = "Tokio pasirinkimo nera!!";
                            break;
                    }
                    Console.WriteLine($"Jus pasirinkote: {pasirinkimoPavadinimas}");
                }
                else
                {
                    Console.WriteLine("tokio pasirinkimo nera");
                }
            }
            else
            {
                Console.WriteLine("Ivedete ne numeri");
            }

            // Papildomos uzduotys nr. 2

            Console.WriteLine("Iveskite 3 skaicius: ");
            int ivedimass = Convert.ToInt32(Console.ReadLine());

            int ppirmasSk = ivedimass / 100;
            int aantrasSk = ivedimass % 100 / 10;
            int ttreciasSk = ivedimass % 10;

            Console.WriteLine(ppirmasSk*aantrasSk*ttreciasSk);


            // Papildoma uzduotis nr. 3 


            Console.WriteLine("Iveskite su skaicius (PVZ: 12, 150)");
            string invedimas = Console.ReadLine();

            invedimas = invedimas.Replace(" ", string.Empty);
            char[] charSeparators = new char[] { ',' };
            string[] sutvarkytasIvedimas = invedimas.Split(charSeparators);

            int pirmasis = Int32.Parse(sutvarkytasIvedimas[0]);
            int antrasis = Int32.Parse(sutvarkytasIvedimas[1]);

            Console.WriteLine($"Sudeties rezultatas {pirmasis+antrasis}");
            Console.WriteLine($"Atimties rezultatas {pirmasis-antrasis}");
            Console.WriteLine($"Daugybos rezultatas {pirmasis*antrasis}");
            Console.WriteLine($"Dalybos rezultatas {(double)pirmasis/antrasis}");
            
            // Papildoma uzduotis nr. 4 

            Console.WriteLine("Iveskite su skaicius (PVZ: 12, 150, 78, 105)");
            string Invedimas = Console.ReadLine();

            Invedimas = Invedimas.Replace(" ", string.Empty);
            char[] charsSeparators = new char[] { ',' };
            string[] SutvarkytasInvedimas = Invedimas.Split(charsSeparators);

            int Pirmasis = Int32.Parse(SutvarkytasInvedimas[0]);
            int Antrasis = Int32.Parse(SutvarkytasInvedimas[1]);
            int Treciasis = Int32.Parse(SutvarkytasInvedimas[2]);
            int Ketvirtasis = Int32.Parse(SutvarkytasInvedimas[3]);

            double vidurkis = (Pirmasis + Antrasis + Treciasis + Ketvirtasis) / 4;

            Console.WriteLine($"Skaiciu {Pirmasis}, {Antrasis}, {Treciasis}, {Ketvirtasis} vidurkis yra {vidurkis}");


            // Papildoma uzduotis nr. 5 Temperaturos konvertavimas   

            Console.WriteLine("Iveskite temperatura farenheitais: ");

            double farenheitai = Int32.Parse(Console.ReadLine());

            double celcijus = (farenheitai - 32)/ 1.8;

            Console.WriteLine("Konvertuota temperatura i celcijus: " + celcijus + "C");


            // 

            // Papildoma uzduotis nr. 6

            Console.WriteLine("Kiek darbuotojas gali iskepti kepalu per valanda?" );
            int KepalaiPerValanda = Int32.Parse(Console.ReadLine()); 

            Console.WriteLine("Kiek darbuotoju turi kepykla?");
            int DarbuotojuSkaicius = Int32.Parse(Console.ReadLine()); 

            Console.WriteLine("Vieno kepalo savikaina?");
            double KepaloSavikaina = Double.Parse(Console.ReadLine());

            Console.WriteLine( "Vieno kepalo pardavimo kaina?");
            double KepaloPardavimoKaina = Double.Parse(Console.ReadLine()); // 2 eur

            int IskeptuKepaluPerDiena = KepalaiPerValanda * 8 * DarbuotojuSkaicius;
            double pelnas = (IskeptuKepaluPerDiena * KepaloPardavimoKaina) - (IskeptuKepaluPerDiena * KepaloSavikaina);
            double pardavimai = IskeptuKepaluPerDiena * KepaloPardavimoKaina;
            double savikainosPradavimai = IskeptuKepaluPerDiena * KepaloSavikaina;
            Console.WriteLine($"Per diena butu iskepama {IskeptuKepaluPerDiena} Kepalai, o  pelnas: {pelnas} " +
                $"EUR \n Viso parduota {pardavimai} EUR, Viso savikainos suma {savikainosPradavimai} EUR");



            Console.ReadKey();
        }
    }
}
