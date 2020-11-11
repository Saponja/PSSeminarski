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
            throw new NotImplementedException();
        }

        public void Save(Pacijent pacijent)
        {
            broker.OpenConnection();
            broker.SavePacijent(pacijent);
            broker.CloseConnection();
        }
    }
}
