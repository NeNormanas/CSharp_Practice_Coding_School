using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    public class Parduotuve
    {
        public string Pavadinimas;
        public string Adresas;
        public int AukstuSkaicius;
        public int AtydarymoData;
        public List<Batas> batai = new List<Batas>();


        public Parduotuve(string pavadinimas, string adresas, int aukstuSkaicius, int atydarmoData)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            AukstuSkaicius = aukstuSkaicius;
            AtydarymoData = atydarmoData;

        }

        public void Informacija()
        {
            Console.WriteLine("Pavadinimas: {0}, Adresas: {1}, Aukstu skaicius: {2}, Atydarymo Metai {3}", Pavadinimas, Adresas, AukstuSkaicius, AtydarymoData);
            

        }
        public void GetBatai()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=GariunuDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Batai", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            batai.Add(new Batas(reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(5), reader.GetInt32(6)));

                        }
                    }
                }
                connection.Close();
            }
        }

    }
}
