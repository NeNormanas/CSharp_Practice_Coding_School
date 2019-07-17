using System;
using System.Collections.Generic;
using System.Text;

namespace LessonEight_At_Home.Data
{
    class CoffeCup
    {
        private List<string> size;
        private int amount = 20;

       
        
        public CoffeCup(List<string> size)
        {
            this.size = size;


        }

        public void PrintSizes(List<string> sizes)
        {
            for (int i = 0; i < sizes.Count; i++)
            {
                Console.Write(sizes[i] + ": ");

            }
            Console.WriteLine();
        }

        public List<string> GetSizes()
        {
            return size;
        }

    }
}
