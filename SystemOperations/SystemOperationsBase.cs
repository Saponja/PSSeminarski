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
        protected Broker broker;

        public SystemOperationsBase()
        {
            broker = new Broker();
        }

        
        public object Result { get; set; }
        public void ExecuteTemplate(IEntity entity = null, List<IEntity> entities = null)
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransaction();
                if(entities != null)
                {
                    foreach (IEntity e in entities)
                    {
                        ExecuteOperation(e);
                    }
                }
                if(entity != null)
                {
                    ExecuteOperation(entity);
                }

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
