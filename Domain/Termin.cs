using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Termin : IEntity
    {
        public DateTime DateTime { get; set; }
        public double Cena { get; set; }
        public Pacijent Pacijent { get; set; }
        public VrstaPregleda VrstaPregleda { get; set; }

        [Browsable(false)]
        public string TableName => "Termini";

        [Browsable(false)]
        //POGLEDATI OVDE ZA INSERT VALUES public string InsertValues => $"{Pacijent.PacijentID}, {VrstaPregleda.PregledID}, '{DateTime}', {Cena}";
        public string InsertValues => $"{Pacijent.PacijentID}, {VrstaPregleda.PregledID}, '{DateTime}', {Cena}";
        [Browsable(false)]
        public string IdColumn => "Datum";
        [Browsable(false)]
        public string SelectColumns => "t.Datum tdat, t.Cena tcena, p.Id pid, p.Ime pime, p.Prezime pprezime," +
            " p.DatumRodjenja pdr, p.Hitan  phitan, p.Anamneza panam, p.SifraBolnice psb, vp.Id vpid, " +
            "vp.Naziv vpnaziv, vp.Oblast vpoblast, vp.LekarId vplek";
        [Browsable(false)]
        public string TableAlias => "t";
        [Browsable(false)]
        public string JoinTable => "join Pacijenti p";
        [Browsable(false)]
        public string JoinCondition => "on (t.PacijentId = p.Id)";
        [Browsable(false)]
        public string JoinTable2 => "join VrstaPregleda vp";
        [Browsable(false)]
        public string JoinCondition2 => "on (t.VrstaPregledaId = vp.Id)";
        [Browsable(false)]
        public string SelectColumnsWhere => "FORMAT (Datum, 'dd.MM.yyyy HH:mm') as Datum";
        [Browsable(false)]
        public string Where => $"";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                bool hitan = false;
                if ((int)reader["phitan"] == 1)
                {
                    hitan = true;
                }
                entities.Add(new Termin
                {
                    DateTime = (DateTime)reader["tdat"],
                    Cena = (double)reader["tcena"],
                    Pacijent = new Pacijent
                    {
                        PacijentID = (int)reader["pid"],
                        Ime = (string)reader["pime"],
                        Prezime = (string)reader["pprezime"],
                        DaumRodjenja = (DateTime)reader["pdr"],
                        Hitan = hitan,
                        Anamneza = (string)reader["panam"],
                        Bolnica = new Bolnica { SifraBolnice = (int)reader["psb"]}

                    },
                    VrstaPregleda = new VrstaPregleda
                    {
                        PregledID = (int)reader["vpid"],
                        Naziv = (string)reader["vpnaziv"],
                        Oblast = (string)reader["vpoblast"],
                        Lekar = new Lekar { LekarID = (int)reader["vplek"]}
                    }
                }
                );
            }

            return entities;
        }

        public List<object> GetObjectsWhere(SqlDataReader reader)
        {
            List<object> objects = new List<object>();
            while (reader.Read())
            {
                string datumString = (string)reader["Datum"];
                DateTime datum = DateTime.ParseExact(datumString, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None);
                objects.Add(datum);
            }

            return objects;
        }
    }
}
