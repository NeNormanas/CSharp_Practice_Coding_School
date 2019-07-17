using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    public class Batas
    {
        public string Gamintojas;
        public int Dydis;
        public string Spalva;
        public string Medziaga;
        public int Kaina;
        public int Nuolaida;


        public Batas(string gamintojas, int dydis, string spalva, string medziaga, int kaina, int nuolaida)
        {
            Gamintojas = gamintojas;
            Dydis = dydis;
            Spalva = spalva;
            Medziaga = medziaga;
            Kaina = kaina;
            Nuolaida = nuolaida;
        }

        public void Informacija()
        {
            Console.WriteLine("Gamintojas: {0}, Dydis: {1}, Spalva: {2}, Medziaga {3}, Kaina: {4}, Nuolaida: {5}, Bato kaina su Nuolaida: {6}", Gamintojas, Dydis, Spalva, Medziaga, Kaina, Nuolaida, KainaSuNuolaida());
            
        }

        public double KainaSuNuolaida()
        {
            double KainaPoNuolaidos = Kaina - (Kaina * Nuolaida / 100);
            return KainaPoNuolaidos;
        }
    

    }


}
