using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Domain;

namespace BrokerDB
{
    public class Broker
    {
        private SqlConnection connection;

        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Klinika;Integrated Security=True;
Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public void OpenConnection()
        {
            connection.Open();
        }
        public void CloseConnection()
        {
            connection.Close();
        }

        public List<Korisnik> GetAllKorisnici()
        {
            List<Korisnik> korisnici = new List<Korisnik>();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from Korisnici";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Korisnik k = new Korisnik()
                {
                    KorisnikId = (int)reader["Id"],
                    Username = (string)reader["Username"],
                    Password = (string)reader["Password"]
                };

                korisnici.Add(k);
            }
            reader.Close();
            return korisnici;
        }

    }
}
