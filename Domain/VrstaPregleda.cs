using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class VrstaPregleda : IEntity
    {
        public int PregledID { get; set; }
        public string Naziv { get; set; }
        public string Oblast { get; set; }
        public Lekar Lekar { get; set; }

        public override string ToString()
        {
            return $"{Naziv}";
        }

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                entities.Add(new VrstaPregleda
                {
                    PregledID = (int)reader["pid"],
                    Naziv = (string)reader["pnaziv"],
                    Oblast = (string)reader["poblast"],
                    Lekar = new Lekar
                    {
                        LekarID = (int)reader["lid"],
                        Ime = (string)reader["lime"],
                        Prezime = (string)reader["lprez"],
                        Specijalizacija = (string)reader["lspec"],
                        Bolnica = new Bolnica
                        {
                            SifraBolnice = (int)reader["bid"],
                            Naziv = (string)reader["bnaziv"],
                            Adresa = (string)reader["badresa"]
                        }
                    }
                });
            }

            return entities;
        }

        public VrstaPregleda Self { get { return this; } }
        [Browsable(false)]
        public string TableName => "VrstaPregleda";
        [Browsable(false)]
        public string InsertValues => $"{PregledID}, '{Naziv}', '{Oblast}', {Lekar.LekarID}";
        [Browsable(false)]
        public string IdColumn => "Id";
        [Browsable(false)]
        public string SelectColumns => "p.Id pid, p.Naziv pnaziv, p.Oblast poblast, l.Id lid, l.Ime lime, " +
            "l.Prezime lprez, l.Specijalizacija lspec, b.Id bid, b.Naziv bnaziv, b.Adresa badresa";
        [Browsable(false)]
        public string TableAlias => "p";
        [Browsable(false)]
        public string JoinTable => "join Lekari l";
        [Browsable(false)]
        public string JoinCondition => "on (p.LekarId = l.Id)";
        [Browsable(false)]
        public string JoinTable2 => "join Bolnice b";
        [Browsable(false)]
        public string JoinCondition2 => "on (l.SifraBolnice = b.Id)";
    }
}
