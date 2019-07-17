using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
   public class Darbuotojas
    {
        public string Vardas;
        public string Pavarde;
        public int DirbaNuo;
        public string Pareigos;
        public int DarboUzmokestis;

        public Darbuotojas(string vardas, string pavarde, int dirbaNuo, string pareigos, int darbouzmokestis)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            DirbaNuo = dirbaNuo;
            Pareigos = pareigos;
            DarboUzmokestis = darbouzmokestis;

        }

        public void Informacija()
        {
            Console.WriteLine("Vardas: {0}, Pavarde: {1}, Dirba nuo: {2}, Pareigos {3}, Darbo uzmokestis: {4}", Vardas, Pavarde, DirbaNuo, Pareigos, DarboUzmokestis);
           

        }
    }

}
