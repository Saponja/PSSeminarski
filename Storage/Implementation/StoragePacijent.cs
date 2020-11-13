using BrokerDB;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Implementation
{
    public class StoragePacijent : IStoragePacijent
    {
        private Broker broker;

        public StoragePacijent()
        {
            broker = new Broker();
        }

        public List<Pacijent> GetAll()
        {
            try
            {
                broker.OpenConnection();
                return broker.GetAllPacijenti();

            }
            finally
            {

                broker.CloseConnection();
            }
        }

        public void Save(Pacijent pacijent)
        {
            broker.OpenConnection();
            broker.SavePacijent(pacijent);
            broker.CloseConnection();
        }

        public void Delete(Pacijent pacijent)
        {
            broker.OpenConnection();
            broker.DeletePacijent(pacijent);
            broker.CloseConnection();
        }
    }
}
