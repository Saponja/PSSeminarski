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
    public class Dijagnoza : IEntity
    {
        public DateTime Datum { get; set; }
        [Browsable(false)]
        public int DijagnozaId { get; set; }
        [Browsable(false)]
        public int PacijentId { get; set; }

        public TipDijagnoze TipDijagnoze { get; set; }
        public Pacijent Pacijent { get; set; }
        [Browsable(false)]
        public string TableName => "Dijagnoza";
        [Browsable(false)]
        public string InsertValues => $"'{Datum}', {DijagnozaId}, {PacijentId}";
        [Browsable(false)]
        public string IdColumn => "";
        [Browsable(false)]
        public string SelectColumns => "d.Datum did, t.DijagnozaId tid, p.Id pid, p.Ime pime, p.Prezime pprez, t.Naziv tnaz";
        [Browsable(false)]
        public string TableAlias => "d";
        [Browsable(false)]
        public string JoinTable => "join Pacijenti p";
        [Browsable(false)]
        public string JoinCondition => "on(d.PacijentId = p.Id)";
        [Browsable(false)]
        public string JoinTable2 => "join TipDijagnoze t";
        [Browsable(false)]
        public string JoinCondition2 => "on(d.DijagnozaId = t.DijagnozaId)";
        [Browsable(false)]
        public string SelectColumnsWhere => "";
        [Browsable(false)]
        public string Where => "";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                entities.Add(new Dijagnoza
                {
                    Datum = (DateTime)reader[0],
                    DijagnozaId = (int)reader[1],
                    PacijentId = (int)reader[2],
                    Pacijent = new Pacijent { Ime = (string)reader[3], Prezime = (string)reader[4]},
                    TipDijagnoze = new TipDijagnoze { Naziv = (string)reader[5]}
                });
            }

            return entities;
        }

        public List<object> GetObjectsWhere(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
