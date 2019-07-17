using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationAndInheritance.AdditionalTask
{
    sealed class Human // sealed neleis paveldeti sitos klases
    {
        private int age;


        public Human(int age)
        {
            this.age = age;

        }
        

        public void Talk()
        {
            Console.WriteLine("Talking");
        }
    }
}
