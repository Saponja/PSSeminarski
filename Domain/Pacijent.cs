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
    public class Pacijent : IEntity
    {
        public int PacijentID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DaumRodjenja { get; set; }
        public bool Hitan { get; set; }
        public string Anamneza { get; set; }
        public Bolnica Bolnica { get; set; }



        public override bool Equals(object obj)
        {
            Pacijent p = obj as Pacijent;

            if (p != null && p.PacijentID == PacijentID)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                bool hitan = false ;
                if((int)reader["phitan"] == 1)
                {
                    hitan = true;
                }
                entities.Add(new Pacijent
                {
                    PacijentID = (int)reader["pid"],
                    Ime = (string)reader["pime"],
                    Prezime = (string)reader["pprezime"],
                    DaumRodjenja = (DateTime)reader["pdr"],
                    Hitan = hitan,
                    Anamneza = (string)reader["panam"],
                    Bolnica = new Bolnica
                    {
                        SifraBolnice = (int)reader["bid"],
                        Naziv = (string)reader["bnaziv"],
                        Adresa = (string)reader["badresa"]
                    }
                }) ;
            }

            return entities;
        }

        
        public Pacijent Self { get { return this; } }

        [Browsable(false)]
        public string TableName => "Pacijenti";
        [Browsable(false)]
        public string InsertValues => $"{PacijentID}, '{Ime}', '{Prezime}', '{DaumRodjenja}', {Convert.ToInt32(Hitan)}, '{Anamneza}', {Bolnica.SifraBolnice}";
        [Browsable(false)]
        public string IdColumn => "Id";
        [Browsable(false)]
        public string SelectColumns => "p.Id pid, p.Ime pime, p.Prezime pprezime, p.DatumRodjenja pdr," +
            " p.Hitan phitan, p.Anamneza panam, b.Id bid, b.Naziv bnaziv, b.Adresa badresa";
        [Browsable(false)]
        public string TableAlias => "p";
        [Browsable(false)]
        public string JoinTable => "join Bolnice b";
        [Browsable(false)]
        public string JoinCondition => "on (p.SifraBolnice = b.Id)";
        [Browsable(false)]
        public string JoinTable2 => "";
        [Browsable(false)]
        public string JoinCondition2 => "";
    }
}
