using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationAndInheritance.AdditionalTask
{
    class SpaceShip : Vechicle
    {
        private int oxygenAmount;


        public SpaceShip (double movingSpeed, int wheelCount, int oxygenAmount) : base(movingSpeed, wheelCount)
        {
            this.oxygenAmount = oxygenAmount;

        }

        public void StartHyperDrive()
        {
            Console.WriteLine("start hyper drive");
        }

    }
}
