using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IEntity
    {
        string TableName { get;}
        string InsertValues { get;}
        string IdColumn { get; }
        string SelectColumns { get; }
        string TableAlias { get; }
        string JoinTable { get; }
        string JoinCondition { get; }
        string JoinTable2 { get; }
        string JoinCondition2 { get; }

        List<IEntity> GetEntities(SqlDataReader reader);
    }
}
