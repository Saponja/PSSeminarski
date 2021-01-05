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

        public string TableName => "Dijagnoza";

        public string InsertValues => $"'{Datum}', {DijagnozaId}, {PacijentId}";

        public string IdColumn => "";

        public string SelectColumns => "";

        public string TableAlias => "";

        public string JoinTable => "";

        public string JoinCondition => "";

        public string JoinTable2 => "";

        public string JoinCondition2 => "";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
