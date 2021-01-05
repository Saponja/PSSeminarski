using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.SOPacijent
{
    public class ObrisiPacijentaSO : SystemOperationsBase
    {
        public override void ExecuteOperation(IEntity entity)
        {
            Pacijent pacijent = (Pacijent)entity;
            broker.Delete(entity, pacijent.PacijentID);
        }
    }
}
