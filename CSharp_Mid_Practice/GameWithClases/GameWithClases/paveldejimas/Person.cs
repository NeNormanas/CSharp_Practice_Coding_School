using System;
using System.Collections.Generic;
using System.Text;

namespace GameWithClases.paveldejimas
{
    class Person
    {
        private string name;
        private DateTime birthday;

        public Person(string name, DateTime birthday)
        {
            this.name = name;
            this.birthday = birthday;


        }

        public void ShowtYourName()
        {
            Console.WriteLine(birthday.ToLongDateString());
        }

    }
}
