﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.SOPregled
{
    public class SacuvajPregledSO : SystemOperationsBase
    {
        public override void ExecuteOperation(IEntity entity)
        {
            broker.Save(entity);
        }
    }
}
