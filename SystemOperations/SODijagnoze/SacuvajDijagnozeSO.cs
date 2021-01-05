using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.SODijagnoze
{
    public class SacuvajDijagnozeSO : SystemOperationsBase
    {
        public override void ExecuteOperation(IEntity entity)
        {
            broker.Save(entity);
        }
    }
}
