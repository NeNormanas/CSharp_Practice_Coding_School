using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationAndInheritance.AdditionalTask
{
    class  Vechicle : MovingObject
    {
        private int wheelCount;

        public Vechicle(double movingSpeed, int wheelCount) : base(movingSpeed)
        {
            this.wheelCount = wheelCount;
        }

        public void WheelChange()
        {
            Console.WriteLine("Changing wheel");
        }   
    }
}
