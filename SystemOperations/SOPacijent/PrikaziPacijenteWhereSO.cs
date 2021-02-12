using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.SOPacijent
{
    public class PrikaziPacijenteWhereSO : SystemOperationsBase
    {
        private string cond;

        public PrikaziPacijenteWhereSO(string cond)
        {
            this.cond = cond;
        }

        public override void ExecuteOperation(IEntity entity)
        {
            Result = broker.GetAll(entity, cond).Cast<Pacijent>().ToList();
        }
    }
}
