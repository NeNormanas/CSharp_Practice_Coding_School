using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationAndInheritance.Data
{
    class Bird : Animal
    {
        public string Color;
        private bool canFly;
        protected string country;

        public Bird (int LegsCount, string gender, int age, string Color, bool canFly, string country): base(LegsCount, gender, age)
        {
            this.Color = Color;
            this.canFly = canFly;
            this.country = country;
        }

        public bool GetCanFly()
        {
            return canFly;
        }

        public string GetCountry()
        {
            return country;
        }

        public void PrintBird()
        {
            Console.WriteLine($"Age{age}, LegsCount: {LegsCount}, gender {gender}, color: {Color}, canfly:{canFly}, country: {country}");
        }

    }
}
