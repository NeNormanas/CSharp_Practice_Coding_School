using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationAndInheritance.AdditionalTask
{
    class  MovingObject
    {
        protected double movingSpeed;



        public MovingObject(double movingSpeed)
        {
            this.movingSpeed = movingSpeed;
        }

        public void Move()
        {
            Console.WriteLine("Object is moving");
        }
        ff
    }
}
