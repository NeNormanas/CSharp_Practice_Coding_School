using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationAndInheritance.AdditionalTask
{
    class Bycicle : Vechicle
    {
        private bool hasHelmet;

        public Bycicle(double movingSpeed, int wheelCount, bool hasHelmet) : base(movingSpeed, wheelCount)
        {
            this.hasHelmet = hasHelmet;

        }

        public void Ride()
        {
            Console.WriteLine("Riding");
        }
    }
}
