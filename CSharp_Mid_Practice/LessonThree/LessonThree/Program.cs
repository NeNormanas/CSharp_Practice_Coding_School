using System;

namespace LessonThree
{
    class Program
    {
        static void Main(string[] args)
        {

            //// Lesson three (Loops)
            //// Pirma uzduotis 



            for (int i = 0; i <= 20; i += 3)
            {
                Console.WriteLine(i);


            }

            //// antra uzduotis 

            Console.WriteLine("Rezio pradzia: ");
            int pradzia = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Rezio pabaiga: ");
            int pabaiga = Int32.Parse(Console.ReadLine());

            if (pradzia > pabaiga)
            {
                Console.WriteLine("Bad inputs");
            }
            else
            {
                for (int i = pradzia; i <= pabaiga; i++)
                {
                    Console.WriteLine($"Skaicius{i - pradzia + 1}: {i}, jo kvadratas: {i * i }");
                }
            }

            // trecia uzduotis 

            int suma = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    suma += i;

                }
            }

            Console.WriteLine("Suma: " + suma);


            //// ketvirta uzduotis

            Console.WriteLine("1. Coffe \n2. Tea \n3. Water");
            Console.WriteLine("Choose your drink: ");

            int input = Int32.Parse(Console.ReadLine());

            while (input <= 0 || input > 3)
            {
                Console.WriteLine("Bad input, choose again: ");
                input = Int32.Parse(Console.ReadLine());
            }

            switch (input)
            {
                case 1:
                    Console.WriteLine("You choose: Kava");
                    break;
                case 2:
                    Console.WriteLine("You choose: Arbata");
                    break;
                case 3:
                    Console.WriteLine("You choose: Vanduo");
                    break;
                default:
                    break;
            }

            // Penkta uzduotis 

            int windowPerson = 0;
            int notwindowPerson = 0;
            do
            {
                Console.WriteLine("Do you want to sit near the window?");
                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "yes":
                    case "y":
                    case "1":
                        windowPerson++;
                        break;
                    case "no":
                    case "n":
                    case "0":
                        notwindowPerson++;
                        break;
                    default:
                        Console.WriteLine("Bad intup , type again!");
                        break;
                }

            } while (windowPerson < 4 && notwindowPerson < 8); ;

            Console.WriteLine("All seats near the window is occupied");

            //// Penkta uzduotis antras budas

            const int totalseats = 8;
            const int windowsseats = 4;

            int totalclientcount = 0;
            int windowclientcount = 0;

            while (windowclientcount < windowsseats && totalclientcount < totalseats)
            {
                Console.WriteLine("Do you want to sit near the window?");
                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "yes":
                    case "y":
                    case "1":
                        totalclientcount++;
                        windowclientcount++;
                        break;
                    case "no":
                    case "n":
                    case "0":
                        totalclientcount++;
                        ;
                        break;
                    default:
                        Console.WriteLine("Bad intup , type again!");
                        break;
                }
            }
            Console.WriteLine("All seats near the window is occupied");

            //// sesta uzduotis 

            int suuma = 0;

            for (int i = 1; i < 1001; i++)
            {
                if (i > 123)
                {
                    break;
                }

                if (i % 5 == 0)
                {
                    continue;
                }

                suuma += i;
            }
            Console.WriteLine(suuma);

            //// sesta uzduotis papildomai

            int sumaaa = 0;
            int j = 0;

            for (;;)
            {
                j++;
                if (j < 1001)
                {
                    if (j > 123)
                    {
                        break;
                    }
                    if (j % 5 == 0)
                    {
                        continue;
                    }
                    sumaaa += j;
                }

            }
            Console.WriteLine(sumaaa);



            // fibonaciu skaiciu seka


            int a = 0;
            int b = 1;
            int c = 0;

            Console.WriteLine("How many Fibonacci numers you want?\n");
            int innput = Int32.Parse(Console.ReadLine());

            if (innput == 1)
            {
                Console.WriteLine($"\n{1} . Fibonacci numer: {a}");
            }
            else
            {
                Console.WriteLine($"\n{1} . Fibonacci numer: {a} \n{2} . Fibonacci numer: {b}");
                for (int i = 2; i < innput; i++)
                {
                    c = a + b;
                    Console.WriteLine($"{i + 1} . Fibonacci numer: {c}");
                    a = b;
                    b = c;
                }
            }
            // papildoma uzduotis su while 

            int cpuNumber = new Random().Next(0, 100);
            int guess = -1;
            int guessCount = 0;
            bool needToContinue = true;

            while (needToContinue)
            {
                while (guess != cpuNumber)
                {

                    Console.WriteLine("Guess the number?");
                    guess = Int32.Parse(Console.ReadLine());

                    if (guess > cpuNumber)
                    {
                        Console.WriteLine("Hidden number is lower");
                    }
                    if (guess < cpuNumber)
                    {
                        Console.WriteLine("Hidden number is higher");
                    }
                    guessCount++;

                }
                needToContinue = false;
            }

            Console.WriteLine("Perfect hidden number was: {0}, you guessed {1} times", cpuNumber, guessCount);

            Console.ReadLine();

            // Papildoma uzduotis - skaiciuotuvas

            bool turnOn = true;

            while (turnOn)
            {
                Console.WriteLine("Write action: +, -, *, / ");
                char symbol = Console.ReadKey(true).KeyChar;
                if (symbol == (char)27)
                {
                    Console.WriteLine("You pressed ESC, bye");
                    break;
                }

                Console.WriteLine("Write number first: ");
                int numberfirst = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Write number second: ");
                int numberSecond = Int32.Parse(Console.ReadLine());

                double answerr = 0;
                string inputas;

                switch (symbol)
                {
                    case '-':
                        answerr = numberfirst - numberSecond;
                        break;
                    case '+':
                        answerr = numberfirst + numberSecond;
                        break;
                    case '*':
                        answerr = numberfirst * numberSecond;
                        break;
                    case '/':
                        answerr = numberfirst / numberSecond;
                        break;
                    default:
                        Console.WriteLine("Bad input");
                        break;
                }
                Console.WriteLine($"Answer is: {answerr}\n");

                Console.WriteLine("Do you want to continue?");
                inputas = Console.ReadLine();
                switch (inputas)
                {
                    case "n":
                    case "0":
                        turnOn = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
