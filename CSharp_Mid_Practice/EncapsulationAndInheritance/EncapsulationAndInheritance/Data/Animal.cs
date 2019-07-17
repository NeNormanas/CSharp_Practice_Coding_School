using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationAndInheritance.Data
{
    class Animal
    {
        // fields 

        public int LegsCount;
        protected string gender;
        protected int age;

        // konstruktorius

        public Animal(int LegsCount, string gender, int age)
        {
            this.LegsCount = LegsCount;
            this.gender = gender;
            this.age = age;
        }

        // Methods

        public string GetGender()
        {
            return gender;
        }

        public int GetAge()
        {
            return age;
        }

        public void PrintAnimal()
        {
            Console.WriteLine($"Age{age}, LegsCount: {LegsCount}, gender {gender}");
        }
    }
}
