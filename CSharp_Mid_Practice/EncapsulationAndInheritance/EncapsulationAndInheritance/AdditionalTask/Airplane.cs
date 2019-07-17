using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationAndInheritance.AdditionalTask
{
    class Airplane : Vechicle
    {
        private int liftPower;


        public Airplane(double movingSpeed, int wheelCount, int liftPower) : base(movingSpeed, wheelCount)
        {
            this.liftPower = liftPower;

        }

        public void Land()
        {
            Console.WriteLine("Landing");
        }
    }
}
