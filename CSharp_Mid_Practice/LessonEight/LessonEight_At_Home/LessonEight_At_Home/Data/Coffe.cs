using System;
using System.Collections.Generic;
using System.Text;

namespace LessonEight_At_Home.Data
{
    class Coffe
    {
        private int id; 
        private string brandName;
        private int strength; // from 1 up to 5;
        private double price;

        public Coffe(int id, string brandName, int strength, double price)
        {
            this.id = id;
            this.brandName = brandName;
            this.strength = strength;
            this.price = price;
        }

        public Coffe()
        {

        }

        public void PrintInfo()
        {
            Console.WriteLine($"{id}. {brandName}, strenght: {strength}, Price: {price}");
        }

        public string GetbrandName()
        {
            return brandName;
        }

        public double GetPrice()
        {
            return price;
        }
       

    }
}
