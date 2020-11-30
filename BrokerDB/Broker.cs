using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Domain;
using System.Data;

namespace BrokerDB
{

    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;


        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Klinika;Integrated Security=True;
Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                 
        }

        //Ispod command = connection.CreateCommand
        //command.Transaction = transaction !!!

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
            //command.CommandText = $"insert into Pacijenti values ({VratiIndeks("Pacijenti")}, '{pacijent.Ime}', '{pacijent.Prezime}', '{pacijent.DaumRodjenja}', {hitan},'{pacijent.Anamneza}', {pacijent.Bolnica.SifraBolnice})";
            command.Parameters.AddWithValue("@Id", VratiIndeks("Pacijenti"));
            command.Parameters.AddWithValue("@Ime", pacijent.Ime);
            command.Parameters.AddWithValue("@Prezime", pacijent.Prezime);
            command.Parameters.AddWithValue("@DatumRodjenja", pacijent.DaumRodjenja);
            command.Parameters.AddWithValue("@Hitan", hitan);
            command.Parameters.AddWithValue("@Anamneza", pacijent.Anamneza);
            command.Parameters.AddWithValue("@Bolnica", pacijent.Bolnica.SifraBolnice);
            command.CommandText = $"insert into Pacijenti values (@Id ,@Ime, @Prezime, @DatumRodjenja, @Hitan, @Anamneza, @Bolnica)";


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
            //command.CommandText = $"Insert into VrstaPregleda values ({VratiIndeks("VrstaPregleda")}, '{pregled.Naziv}', '{pregled.Oblast}', {pregled.Lekar.LekarID})";
            command.Parameters.AddWithValue("@Id", VratiIndeks("VrstaPregleda"));
            command.Parameters.AddWithValue("@Naziv", pregled.Naziv); 
            command.Parameters.AddWithValue("@Oblast", pregled.Oblast);
            command.Parameters.AddWithValue("@Lekar", pregled.Lekar.LekarID);
            command.CommandText = $"Insert into VrstaPregleda values(@Id, @Naziv, @Oblast, @Lekar)";

            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Pogresno unet predmet");
            }

        }

        public List<VrstaPregleda> GetAllVrstaPregleda()
        {
            List<VrstaPregleda> pregledi = new List<VrstaPregleda>();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from VrstaPregleda inner join Lekari on(VrstaPregleda.LekarId = Lekari.Id) inner join Bolnice on(Lekari.SifraBolnice = Bolnice.Id)";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                VrstaPregleda pregled = new VrstaPregleda()
                {
                    PregledID = (int)reader[0],
                    Naziv = (string)reader[1],
                    Oblast = (string)reader[2],
                    Lekar = new Lekar()
                    {
                        LekarID = (int)reader[3],
                        Ime = (string)reader[5],
                        Prezime = (string)reader[6],
                        Specijalizacija = (string)reader[7],
                        Bolnica = new Bolnica()
                        {
                            SifraBolnice = (int)reader[8],
                            Naziv = (string)reader[10],
                            Adresa = (string)reader[11]
                        }
                    }
                };
                pregledi.Add(pregled);
            }
            reader.Close();
            return pregledi;



        } 

        public void SaveTermin(Termin termin)
        {
            SqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;

            command.Parameters.AddWithValue("@PacijentId", termin.Pacijent.PacijentID);
            command.Parameters.AddWithValue("@PregledId", termin.VrstaPregleda.PregledID);
            //command.Parameters.Add("@Datum", SqlDbType.DateTime2);
            //command.Parameters.Add("@Datum");
            command.Parameters.AddWithValue("@Datum", termin.DateTime);
            command.Parameters.AddWithValue("@Cena", termin.Cena);
            command.CommandText = $"insert into Termini values (@PacijentId, @PregledId, @Datum, @Cena)";

            command.ExecuteNonQuery();
        }

        public List<DateTime> GetVremeTermina()
        {
            List<DateTime> datumi = new List<DateTime>();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select Datum from Termini";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                datumi.Add((DateTime)reader["Datum"]);
            }
            reader.Close();
            return datumi;
        }

        public List<Termin> GetAllTermini()
        {
            List<Pacijent> pacijenti = GetAllPacijenti();
            List<VrstaPregleda> pregledi = GetAllVrstaPregleda();
            List<Termin> termini = new List<Termin>();
            SqlCommand command = connection.CreateCommand();
            //command.CommandText = $"select * from Termini inner join Pacijenti on (Pacijenti.Id = Termini.PacijentId) inner join VrstaPregleda on (Termini.VrstaPregledaId = VrstaPregleda.Id)";
            command.CommandText = $"select * from Termini";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Termin termin = new Termin()
                {
                    DateTime = reader.GetDateTime(2),
                    Cena = reader.GetDouble(3),
                    Pacijent = pacijenti.Single(p => p.PacijentID == (int)reader["PacijentId"]),
                    VrstaPregleda = pregledi.Single(p => p.PregledID == (int)reader["VrstaPregledaId"]),
                };

                termini.Add(termin);
            }
            reader.Close();
            return termini;
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }

        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();

        }

    }
}
