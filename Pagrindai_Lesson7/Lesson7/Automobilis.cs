using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    public class Automobilis
    {
        //Duomenys arba klases nariai arba properties
        public string Marke;
        public int Metai;
        public int rida;
        public string Spalva;
        public string Modelis;
        public double Litrai;
        public int Atstumas;

        public Automobilis(string marke, int metai, string spalva, int Rida, string modelis, double litrai, int atstumas) // musu sukurtas konstruktorius
        {

            Marke = marke;
            Metai = metai;
            Spalva = spalva;
            rida = Rida;
            Modelis = modelis;
            Litrai = litrai;
            Atstumas = atstumas;



        }
        // klases metodai
        public double kilometraiPerMetus()
        {
            int praejoMetu = 2019 - Metai;
            double kmPerMetus = (double)rida / praejoMetu;
            return kmPerMetus;
        }
        #region
        public void Spauzdinti()
        {
            Console.WriteLine("Automobilio marke: {0}, metai{1}, rida: {2}, spalva {3}, modelis {4}, kilometrai Per MEtus: {5}, myliomis rida: {6}, Vidutines sanaudos: {7} litrai/kilometrui", 
                Marke, Metai, rida, Spalva, Modelis, kilometraiPerMetus(), konvertavimas(), Sanaudos() );
        }

        public double konvertavimas()
        {

            return (rida * 0.621);
        }
        public double Sanaudos()
        {
            return 100 * Litrai / Atstumas;
        }
        #endregion


    }
}
