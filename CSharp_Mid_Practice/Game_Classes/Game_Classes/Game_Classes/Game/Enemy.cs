using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Classes.Game
{

    class Enemy
    {
        private int id;
        private int x = 0;
        private int y = 0;
        private string name;

        public Enemy(int id, int x, int y, string name)
        {
            this.id = id;
            this.x = x;
            this.y = y;
            this.name = name;

        }

        public void MoveDown()
        {
            y--;
        }

        public void PrintInfo()
        {
            Console.WriteLine($" Enemy Name: {name}, x = {x}, y = {y}");
        }

        public int GetId()
        {
            return id;
        }

    }
}
