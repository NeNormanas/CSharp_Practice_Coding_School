using System;
using System.Collections.Generic;
using System.Text;

namespace LessonEight.Krepsinis
{
    class Ball
    {
        public double Radius = 50;
        public int Size;
        public string Color;
        public string Name;
        private double _price;
        public double X;
        public double Y;
        public double Z;
        


        public Ball(double radius, int size, string color, double price,  double x, double y, double z, string name)
        {
            this.Radius = radius; // kai vienodi pavadinimai naudoti THIS, kad atskirti kuris atejas is klases
            this.Size = size;
            this.Color = color;
            _price = price;
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.Name = name;
        }

        public void Bounce()
        {

        }

        public void ChangePosition(double newx, double newy, double newz)
        {
            X = newx;
        }

        private void CalculateSpeed()
        {

        }
    }
}
