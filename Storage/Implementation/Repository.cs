using BrokerDB;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Implementation
{
    public class Repository : IRepository
    {
        private Broker broker = new Broker();

        public void Delete(IEntity entity, int id)
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransaction();
                broker.Delete(entity, id);
                broker.Commit();
            }
            catch (Exception)
            {
                broker.Rollback();
                throw;
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public List<IEntity> GetAll(IEntity entity)
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransaction();
                List<IEntity> entities = broker.GetAll(entity);
                broker.Commit();
                return entities;
            }
            catch (Exception)
            {
                broker.Rollback();
                throw;
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public int GetNewId(IEntity entity)
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransaction();
                int id =  broker.GetNewId(entity);
                broker.Commit();
                return id;
            }
            catch (Exception)
            {
                broker.Rollback();
                throw;
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public void Save(IEntity entity)
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransaction();
                broker.Save(entity);
                broker.Commit();
            }
            catch (Exception)
            {
                broker.Rollback();
                throw;
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public void SaveMore(List<IEntity> entities)
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransaction();
                foreach (IEntity entity in entities)
                {
                    broker.Save(entity);
                }
                broker.Commit();
            }
            catch (Exception)
            {
                broker.Rollback();
                throw;
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public void Update(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
