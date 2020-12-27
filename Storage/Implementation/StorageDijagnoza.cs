using BrokerDB;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Implementation
{
    public class StorageDijagnoza : IStorageDijagnoza
    {

        private Broker broker;
        public StorageDijagnoza()
        {
            broker = new Broker();
        }
        public List<Dijagnoza> Get()
        {
            try
            {
                broker.OpenConnection();
                return broker.GetDijagnoze();
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public List<TipDijagnoze> GetTip()
        {
            try
            {
                broker.OpenConnection();
                return broker.GetTip();
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public void Insert(Dijagnoza dijagnoza)
        {
            
        }

        public void SaveMoreDijagnoze(List<Dijagnoza> dijagnoze)
        {
            broker.OpenConnection();
            broker.BeginTransaction();
            try
            {
                int brojac = 0;
                foreach (Dijagnoza dijagnoza in dijagnoze)
                {
                    if(brojac == dijagnoze.Count)
                    {
                        break;
                    }
                    broker.InsertDijagnoza(dijagnoza);
                }
                broker.Commit();
            }
            catch
            {
                broker.Rollback();
            }
            finally
            {
                broker.CloseConnection();
            }
        }
    }
}
