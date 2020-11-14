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

        public List<Pacijent> GetAllPacijenti()
        {
            List<Pacijent> pacijenti = new List<Pacijent>();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from Pacijenti inner join Bolnice on(Pacijenti.SifraBolnice = Bolnice.Id)";
            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                bool hitan = false;
                if ((int)reader["Hitan"] == 1)
                {
                    hitan = true;
                }
                Bolnica bolnica = new Bolnica()
                {
                    SifraBolnice = (int)reader["SifraBolnice"],
                    Naziv = (string)reader["Naziv"],
                    Adresa = (string)reader["Adresa"]

                };
                pacijenti.Add(new Pacijent()
                {
                    PacijentID = (int)reader["Id"],
                    Ime = (string)reader["Ime"],
                    Prezime = (string)reader["Prezime"],
                    DaumRodjenja = (DateTime)reader["DatumRodjenja"],
                    Hitan = hitan,
                    Anamneza = (string)reader["Anamneza"],
                    Bolnica = bolnica
                }) ; 
            }
            reader.Close();
            return pacijenti;

        }

        public void SavePacijent(Pacijent pacijent)
        {
            int hitan = 0;
            if(pacijent.Hitan == true)
            {
                hitan = 1;
            }
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"insert into Pacijenti values ({VratiIndeks("Pacijenti")}, '{pacijent.Ime}', '{pacijent.Prezime}', '{pacijent.DaumRodjenja}', {hitan},'{pacijent.Anamneza}', {pacijent.Bolnica.SifraBolnice})";
            if(command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Pogresan unos pacijenta");
            }


        }

        public int VratiIndeks(string tabela)
        {
            List<Bolnica> bolnice = new List<Bolnica>();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select max(Id) from {tabela}";
            object result = command.ExecuteScalar();
            if (result is DBNull)
            {
                return 1;
            }

            return ((int)result + 1);

        }

        public Bolnica vratiBolnicu(int id)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from Bolnice where Id = {id}";
            SqlDataReader reader = command.ExecuteReader();

            if(reader.Read())
            {
                reader.Close();
                return new Bolnica()
                {
                    SifraBolnice = (int)reader["Id"],
                    Naziv = (string)reader["Naziv"],
                    Adresa = (string)reader["Adresa"]
                };
            }
            reader.Close();
            return null;
        }

        public void DeletePacijent(Pacijent pacijent)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"delete from Pacijenti where Id = {pacijent.PacijentID}";
            if(command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Ne moze da obrise pacijenta");
            }

        }

        public List<Lekar> GetAllLekari()
        {
            List<Lekar> lekari = new List<Lekar>();
            SqlCommand command = connection.CreateCommand();
            command.CommandText =  $"select* from Lekari inner join Bolnice on(Lekari.SifraBolnice = Bolnice.Id)";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Bolnica bolnica = new Bolnica()
                {
                    SifraBolnice = (int)reader["SifraBolnice"],
                    Naziv = (string)reader["Naziv"],
                    Adresa = (string)reader["Adresa"]

                };
                lekari.Add(new Lekar()
                {
                    LekarID = (int)reader["Id"],
                    Ime = (string)reader["Ime"],
                    Prezime = (string)reader["Prezime"],
                    Specijalizacija = (string)reader["Specijalizacija"],
                    Bolnica = bolnica
                    
                });
            }
            reader.Close();
            return lekari;

        }

        public void SaveVrstaPregleda(VrstaPregleda pregled)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"Insert into VrstaPregleda values ({VratiIndeks("VrstaPregleda")}, '{pregled.Naziv}', '{pregled.Oblast}', {pregled.Lekar.LekarID})";
            if(command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Pogresno unet predmet");
            }

        }

    }
}
