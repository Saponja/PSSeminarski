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
    public class Korisnik : IEntity
    {
        public int KorisnikId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        [Browsable(false)]
        public string TableName => "Korisnici";
        [Browsable(false)]
        public string InsertValues => "";
        [Browsable(false)]
        public string IdColumn => "";
        [Browsable(false)]
        public string SelectColumns => "Id, Username, Password";
        [Browsable(false)]
        public string TableAlias => "k";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string JoinCondition => "";
        [Browsable(false)]
        public string JoinTable2 => "";
        [Browsable(false)]
        public string JoinCondition2 => "";

        public string SelectColumnsWhere => "";

        public string Where => "";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                entities.Add(new Korisnik
                {
                    KorisnikId = (int)reader[0],
                    Username = (string)reader[1],
                    Password = (string)reader[2]
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
