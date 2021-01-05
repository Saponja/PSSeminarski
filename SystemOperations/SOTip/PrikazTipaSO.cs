using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SystemOperations.SOTip
{
    public class PrikazTipaSO : SystemOperationsBase
    {
        public override void ExecuteOperation(IEntity entity)
        {
            Result = broker.GetAll(entity).Cast<TipDijagnoze>().ToList();
        }
    }
}
