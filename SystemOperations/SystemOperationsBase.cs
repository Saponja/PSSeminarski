using BrokerDB;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public abstract class SystemOperationsBase
    {
        Broker broker = new Broker();
        public object Result { get; set; }
        public void ExecuteTemplate(IEntity entity)
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransaction();
                ExecuteOperation(entity);
                broker.Commit();
            }
            catch (Exception)
            {
                broker.Rollback();
                
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public abstract void ExecuteOperation(IEntity entity);
    }
}
