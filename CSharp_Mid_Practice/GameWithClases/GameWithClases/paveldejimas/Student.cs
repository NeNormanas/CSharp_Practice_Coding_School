using System;
using System.Collections.Generic;
using System.Text;

namespace GameWithClases.paveldejimas
{
    class Student : Person
    {
        private int termNr =1;
        private string course;


        public Student(string name, DateTime birthday, string course) : base(name,birthday)
        {
            this.course = course;
            

        }


    }
}
