using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class TipDijagnoze : IEntity
    {
        public int DijagnozaID { get; set; }
        public string Naziv { get; set; }

        public string TableName => "TipDijagnoze";

        public string InsertValues => "";

        public string IdColumn => "DijagnozaId";

        public string SelectColumns => "d.DijagnozaId did, d.Naziv dnaziv";

        public string TableAlias => "d";

        public string JoinTable => "";

        public string JoinCondition => "";

        public string JoinTable2 => "";

        public string JoinCondition2 => "";

        public string SelectColumnsWhere => "";

        public string Where => "";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                entities.Add(new TipDijagnoze
                {
                    DijagnozaID = (int)reader["did"],
                    Naziv = (string)reader["dnaziv"]
                });
            }

            return entities;
        }

        public List<object> GetObjectsWhere(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Naziv}";
        }
    }
}
