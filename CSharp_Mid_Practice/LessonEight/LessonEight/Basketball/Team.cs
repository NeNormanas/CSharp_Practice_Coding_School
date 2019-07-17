using System;
using System.Collections.Generic;
using System.Text;

namespace LessonEight.Krepsinis
{
    class Team
    {
        public List<string> SponsorsName;
        public string Name;
        private double _buget;
        public string Country;
        private int _ratio;
        public int MembersCount;
        
        // KONSTRUKTORIUS

       public Team (List<string> sponsorsName, string Name, double Buget, string Country, int Ratio, int MembersCount)
        {
            SponsorsName = sponsorsName;
            this.Name = Name;
            _buget = Buget;
            this.Country = Country;
            _ratio = Ratio;
            this.MembersCount = MembersCount;

            }


        // FUNKCIJOS


        public void GoToCourt()
        {

        }

    }

}
