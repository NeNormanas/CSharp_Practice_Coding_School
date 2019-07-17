using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationAndInheritance.AdditionalTask
{
    class Car : Vechicle
    {
        private bool hasAirBags;


        public Car(double movingSpeed, int wheelCount, bool hasAirBags) : base(movingSpeed, wheelCount)
        {
            this.hasAirBags = hasAirBags;

        }

        public void Drift()
        {
            Console.WriteLine("Drifting");
        }
    }
}
