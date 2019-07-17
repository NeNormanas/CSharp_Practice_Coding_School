using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationAndInheritance.AdditionalTask
{
    class Flyer : Vechicle
    {
        private int altitude;

        
        public Flyer(double movingSpeed, int wheelCount, int altitude) : base(movingSpeed, wheelCount)
        {
            this.altitude = altitude;

        }

        public void PitchUp()
        {
            Console.WriteLine("Pitching up");
        }
    }
}
