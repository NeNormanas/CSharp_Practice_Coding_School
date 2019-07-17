using System;

namespace LessonFour
{
    class Program
    {
        static void Main(string[] args)
        {
            // HOME WORK MAIN
            int result = Max(2, 3, 79);
            Console.WriteLine(result);

            bool answerr = InRange(8, 9, -8);
            Console.WriteLine(answerr);

            bool atsakymas = Primal(30);
            Console.WriteLine(atsakymas);

            Console.ReadKey();


            // Task number 1.

            int numeris = 5;

            numeris = normalNumber(numeris);
            Console.WriteLine(numeris);

            refNumber(ref numeris);
            Console.WriteLine(numeris);

            outnumber(out numeris);
            Console.WriteLine(numeris);

            Console.ReadKey();
            
            int FirstNumber = TypeNumber();
            int SecondNumber = TypeNumber();

            double sum = Sum(FirstNumber, SecondNumber);
            double difference = Difference(FirstNumber, SecondNumber);
            double saundauga = Sandauga(FirstNumber, SecondNumber);
            double dalyba = Dalyba(FirstNumber, SecondNumber);

            Printer(sum, difference, saundauga, dalyba);


            // nepaduodant paramentru, by defoult buvo issaugota 0.
            double answer = Sum();

            Console.WriteLine(answer);


            // KMI Sskaiciavimai 

            double weight = InputDouble("Write weight:");
            double height = InputDouble("Write height:");

            double KMIanswer = KMICounting(weight, height);
            Console.WriteLine("Your KMI is: {0} ", KMIanswer);

            string KMIstatus = KMIStatus(KMIanswer);
            Console.WriteLine(KMIstatus);

            Console.ReadLine();


            Console.WriteLine(FirstNumber + "" + SecondNumber);



            string parameter = "Sending info to function parameters";

            PrintHelloWorld(parameter);
            PrintHelloWorld(Console.ReadLine()); // galima paduoti parametrus tiesiogiai ivedant duomenis

            Console.ReadLine();

            

           


        }



        // List of functions


        static void PrintHelloWorld(string input)
        {

            SaySomething();
            Console.WriteLine("Hello world");
            Saybye();
            Console.WriteLine(input);
        }

        static void SaySomething()
        {
            Console.WriteLine("Something");
        }

        static void Saybye()
        {
            Console.WriteLine("Bye");
        }

        static int TypeNumber()
        {
            Console.WriteLine("Type your number:");
            return Int32.Parse(Console.ReadLine());

        }

        static double Sum(int x = 0, int y = 0)
        {
            return x + y;

        }

        static double Difference(int x = 0, int y = 0)
        {
            return x - y;

        }

        static double Sandauga(int x = 0, int y = 0)
        {
            double answer = x * y;
            return answer;
        }

        static double Dalyba(int x = 0, int y = 0)
        {
            double answer = x / y;
            return answer;
        }

        static void Printer(double a, double b, double c, double d)
        {
            Console.WriteLine($"Results: {a}, {b}, {c}, {d}");
        }

        static double InputDouble (string message)
        {
            Console.WriteLine(message);
            return double.Parse(Console.ReadLine());
        }

        static double KMICounting(double x, double y)
        {
            return x / (y * y);
        }

        static string KMIStatus(double x)
        {
            string answer;

            if (x <= 15.5)
            {
                answer = "badaujantis zmogus";
            }
            else if (x > 15.5 && x < 18.5)
            {
                answer = "liesas zmogus";
            }
            else if (x >= 18.5 && x <= 25)
            {
                answer = "normalaus svorio zmogus";
            }
            else if (x > 25 && x <= 30)
            {
                answer = "virsvorio turntis zmogus";
            }
            else if (x > 30 && x <= 40)
            {
                answer = "nutukes zmogus";
            }
            else
            {
                answer = "ligotai nutukes zmogus";
            }

            return answer;

           
        }

        static int normalNumber(int number)
        {
            return number * 2;

        }

        static void refNumber (ref int number)
        {
            number *= 1;
        }

        static void outnumber (out int number2)
        {
            number2 = 5;
            number2 *= 2;

        }

        // HOME WORK

        static int Max(int x, int y, int z)
        {
            int result = 0; 

            if (x > y && x > z)
            {
                result = x;
            }
            else if (y > x && y > z)
            {
                result = y;
            }
            else if (z > y && z > x)
            {
                result = z;
            }
            else
            {
                Console.WriteLine("No max value");
                result = 000;
            }
            return result;
        } 

        static bool InRange (int x, int y, int z)
        {
            if (x > y && x < z || x > z && x < y)
            {
                return true;
            }

            return false;
        }


        static bool Primal (int x)
        {
            bool result;

            if (x % x == 0 && x % 1 == 0)
            {
                result = true;
            }
            return false;
        }
    }
}
