using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.SOBolnice
{
    public class PrikazBolnicaSO : SystemOperationsBase
    {
        public override void ExecuteOperation(IEntity entity)
        {
            Result = broker.GetAll(entity).Cast<Bolnica>().ToList();
        }
    }
}
