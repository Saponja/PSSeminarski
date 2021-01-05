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
    public class Lekar : IEntity
    {
        public int LekarID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Specijalizacija { get; set; }
        public Bolnica Bolnica { get; set; }

        [Browsable(false)]
        public string TableName => "Lekari";
        [Browsable(false)]
        public string InsertValues => "";
        [Browsable(false)]
        public string IdColumn => "Id";
        [Browsable(false)]
        public string SelectColumns => "l.Id lid, l.Ime lime, l.Prezime lprez, l.Specijalizacija lspec, " +
            "b.Id bid, b.Naziv bnaziv, b.Adresa badresa";
        [Browsable(false)]
        public string TableAlias => "l";
        [Browsable(false)]
        public string JoinTable => "join Bolnice b";
        [Browsable(false)]
        public string JoinCondition => "on (l.SifraBolnice = b.Id)";
        [Browsable(false)]
        public string JoinTable2 => "";
        [Browsable(false)]
        public string JoinCondition2 => "";
        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                entities.Add(new Lekar
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
                });
            }

            return entities;
        }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }

    }
}
