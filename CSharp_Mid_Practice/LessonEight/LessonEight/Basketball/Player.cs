using System;
using System.Collections.Generic;
using System.Text;

namespace LessonEight.Krepsinis
{
    class Player
    {
        private double _hight;
        private double _weight;
        public int Age;
        public string PlayingPosition;
        public double AveragePPG;
        public List<int> MvpYears;


        public Player (double hight, double weight, int age, string playingPosition, double averagePPG, List<int> mvpYears)
        {
            _hight = hight;
            _weight = weight;
            Age = age;
            this.PlayingPosition = playingPosition;
            this.AveragePPG = averagePPG;
            this.MvpYears = mvpYears;
        }

        public int Pass(int age)
        {

            Console.WriteLine("I am making a pass");
            return age * 7;
        }

        public void Shot()
        {

        }

        public void Block()
        {

        }
    }
}
