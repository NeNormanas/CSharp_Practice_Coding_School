using LessonEight.Basketball;
using LessonEight.Krepsinis;
using System;
using System.Collections.Generic;

namespace LessonEight
{
    class Program
    {
        static void Main(string[] args)
        {

            Team Zalgiris = new Team(new List<string>() { "Kalnapils", "Seb bankas" }, "Zalgiris Kaunas", 10000, "Lietuva", 5, 27);

            Player First = new Player(1.98, 105, 25, "SG", 12.5, new List<int>() { 2001, 2005, 2009 });

            Ball Pirmas = new Ball(25, 7, "red", 125, 0, 0, 0, "Spalding");

            Coach Treneris1 = new Coach("Sarunas", 56, 25600);

            Console.WriteLine(Zalgiris.Country); // atspauzdinu kintamaji

            Zalgiris.Country = "Vokietija"; // pakeiciu kintamojo reiksme

            int skacius = First.Pass(First.Age); // kvieciu funkcija is klases Player kuri nieko nepriima ir nieko negrazina
            Console.WriteLine(skacius);



        }
}
}
