using System;
using System.Collections.Generic;
using System.Text;

namespace LessonEight_At_Home.Data
{
    class Customer
    {
        private int choiseCoffeType;
        private string choiseCupSize;
        private int choiseCoffeBrand;
        private double money;

        public Customer(double money)
        {
            this.money = money;
        }

        public void CoffeBrandSelection()
        {
            choiseCoffeBrand = Int32.Parse(Console.ReadLine());
        }

        public void CoffeSelection()
        {
            
           choiseCoffeType = Int32.Parse(Console.ReadLine());
        }

        public void CupSizeSelection()
        {
            
           choiseCupSize = Console.ReadLine();

        }

        public void Payment(double price)
        {
            money = money - price;
        }

        public int GetCoffeSelection()
        {
            return choiseCoffeType;
        }

        public string GetCupSizeSelection()
        {
            return choiseCupSize;

        }
        public int GetBrandSelection()
        {
            return choiseCoffeType;
        }
        
        public double GetMoney()
        {
            return money;
        }

    }
}
