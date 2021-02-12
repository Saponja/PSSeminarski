using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Bolnica : IEntity
    {
        public int SifraBolnice { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }

        public string TableName => "Bolnice";

        public string InsertValues => "";

        public string IdColumn => "";

        public string SelectColumns => "*";

        public string TableAlias => "";

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
                entities.Add(new Bolnica()
                {
                    SifraBolnice = (int)reader["Id"],
                    Naziv = (string)reader["Naziv"],
                    Adresa = (string)reader["Adresa"]
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
            return $"{Naziv}, {Adresa}";
        }
    }
}