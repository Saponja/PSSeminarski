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

        public List<Bolnica> GetAllBolnice()
        {
            List<Bolnica> bolnice = new List<Bolnica>();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from Bolnice";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                bolnice.Add(new Bolnica()
                {
                    SifraBolnice = (int)reader["Id"],
                    Naziv = (string)reader["Naziv"],
                    Adresa = (string)reader["Adresa"]
                });
            }
            reader.Close();
            return bolnice;

        }

        public void SavePacijent(Pacijent pacijent)
        {
            int hitan = 0;
            if(pacijent.Hitan == true)
            {
                hitan = 1;
            }
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"insert into Pacijenti values ({VratiIndeksPacijenta()}, '{pacijent.Ime}', '{pacijent.Prezime}', '{pacijent.DaumRodjenja}', {hitan},'{pacijent.Anamneza}', {pacijent.Bolnica.SifraBolnice})";
            if(command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Pogresan unos pacijenta");
            }


        }

        public int VratiIndeksPacijenta()
        {
            List<Bolnica> bolnice = new List<Bolnica>();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select max(Id) from Pacijenti";
            object result = command.ExecuteScalar();
            if (result is DBNull)
            {
                return 1;
            }

            return ((int)result + 1);

        }

    }
}
