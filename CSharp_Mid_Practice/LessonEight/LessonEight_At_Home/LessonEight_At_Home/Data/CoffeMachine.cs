using System;
using System.Collections.Generic;
using System.Text;


namespace LessonEight_At_Home.Data
{
    class CoffeMachine
    {
        private List<string> menu;
        private int milkLeft = 2000; // mililitres


        public CoffeMachine(List<string> menu, int milkLeft)
        {
            this.menu = menu;
            this.milkLeft = milkLeft;


        }

        public void ShowMainMenu(List<string> menu)
        {
            Console.WriteLine("WELCOME\n");

            Console.WriteLine("Menu:");
            for (int i = 0; i < menu.Count; i++)
            {
                Console.WriteLine((i+1) + " " + menu[i]);

            }

        }

        public void MakeCoffe(int x, string y, int z, string a, string b, string c)
        {
            string text = "Coffe Machine is Making: ";
            string text_2 = "";
            string text_3 = "";
            string text_4 = "" ;

            switch (y)
            {
                case "S": text_2 = "Small";break;
                case "M": text_2 = "Medium";break;
                case "L": text_2 = "Large";break;
                case "XL": text_2 = "Extra Large";break;
                default:
                    break;
            }

            switch (x)
            {
                case 1: text_3= menu[0];break;
                case 2: text_3= menu[1];break;
                case 3: text_3= menu[2];break;
                case 4: text_3= menu[3];break;
                default:
                    break;
            }

            switch (z)
            {
                case 1: text_4 = a;break;
                case 2: text_4 = b;break;
                case 3: text_4 = c;break;
                default:
                    break;
            }

            Console.WriteLine(text + text_4 +" " + text_2 +" " + text_3);
        }
       

        public int MilkUsage()
        {
            return 0;
        }
            
    }

    
}
