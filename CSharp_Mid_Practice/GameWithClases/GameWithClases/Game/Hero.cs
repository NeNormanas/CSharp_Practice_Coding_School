using System;
using System.Collections.Generic;
using System.Text;

namespace GameWithClases.Game
{
    class Hero
    {
        private int x = 30;
        private int y = 25;
        private string name;

        public Hero(string name)
        {
            this.name = name;

        }

        public Hero(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;

        }

        public void MoveRight()
        {
            x++;

        }
        public void MoveLeft()
        {
            x--;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {name}, X = {x}, Y = {y}");

        }



    }
}
