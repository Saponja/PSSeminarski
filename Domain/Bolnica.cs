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

        public string TableName => throw new NotImplementedException();

        public string InsertValues => throw new NotImplementedException();

        public string IdColumn => throw new NotImplementedException();

        public string SelectColumns => throw new NotImplementedException();

        public string TableAlias => throw new NotImplementedException();

        public string JoinTable => throw new NotImplementedException();

        public string JoinCondition => throw new NotImplementedException();

        public string JoinTable2 => throw new NotImplementedException();

        public string JoinCondition2 => throw new NotImplementedException();

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Naziv}, {Adresa}";
        }
    }
}