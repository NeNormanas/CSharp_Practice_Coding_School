using System;
using System.Collections.Generic;

namespace LessonEight_At_Home.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> menu = new List<string>() { "Late", "Coffe with milk", "Capuchino", "Coffe with chocolate" };
            List<string> cupSizes = new List<string>() { "S", "M", "L", "XL" };

            //OBJECTS 

            CoffeMachine Machine = new CoffeMachine(menu, 2000);
            CoffeCup CupSize = new CoffeCup(cupSizes);
            Customer Client_1 = new Customer(100);
            Coffe brandCofy_1 = new Coffe(1, "Aroma", 3, 0.80);
            Coffe brandCofy_2 = new Coffe(2, "Merild", 4, 1.20);
            Coffe brandCofy_3 = new Coffe(3, "Lavazza", 4, 2.00);




            // PROGRAM

            Machine.ShowMainMenu(menu);

            Console.WriteLine("\nPosibilities of brands:\n");

            brandCofy_1.PrintInfo();
            brandCofy_2.PrintInfo();
            brandCofy_3.PrintInfo();

            Console.WriteLine("\nChoose Coffe Brand:");

            Client_1.CoffeBrandSelection();


            Console.WriteLine("\nChoose number of Your Drink:");

            Client_1.CoffeSelection();

            Console.WriteLine("\nChoose size of Your Drink: \n");

            CupSize.PrintSizes(CupSize.GetSizes());

            Client_1.CupSizeSelection();

            brandCofy_1.GetbrandName();

            Machine.MakeCoffe(Client_1.GetCoffeSelection(), Client_1.GetCupSizeSelection(), Client_1.GetCoffeSelection(),
                brandCofy_1.GetbrandName(),
                brandCofy_2.GetbrandName(),
                brandCofy_3.GetbrandName()
                );

            if (Client_1.GetBrandSelection() == 1)
            {
                Client_1.Payment(brandCofy_1.GetPrice());
            }
            else if (Client_1.GetBrandSelection() == 2)
            {
                Client_1.Payment(brandCofy_2.GetPrice());
            }
            else
            {
                Client_1.Payment(brandCofy_3.GetPrice());
            }

            Console.WriteLine("Kliento likutis:" + Client_1.GetMoney());







            Console.ReadKey();


        }
    }
}
