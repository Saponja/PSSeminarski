using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.SOPacijent
{
    public class SacuvajPacijentaSO : SystemOperationsBase
    {
        public override void ExecuteOperation(IEntity entity)
        {
            broker.Save(entity);
            Result = true;
        }
    }
}
