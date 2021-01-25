using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.SOTermin
{
    public class SledeciTerminSO : SystemOperationsBase
    {

        private string cond;

        public SledeciTerminSO(string cond)
        {
            this.cond = cond;
        }
        public override void ExecuteOperation(IEntity entity)
        {
            Result = (DateTime)broker.GetMax(entity, cond);
        }
    }
}
