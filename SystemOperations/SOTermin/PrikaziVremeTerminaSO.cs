using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.SOTermin
{
    public class PrikaziVremeTerminaSO : SystemOperationsBase
    {
        private string cond;
        public PrikaziVremeTerminaSO(string cond)
        {
            this.cond = cond;
        }
        public override void ExecuteOperation(IEntity entity)
        {
            Result = broker.GetWhere(entity, cond).Cast<DateTime>().ToList();
        }
    }
}
