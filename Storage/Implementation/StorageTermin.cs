using BrokerDB;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Implementation
{
    public class StorageTermin : IStorageTermin
    {
        private Broker broker;

        public StorageTermin()
        {
            broker = new Broker();
        }
        public List<Termin> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Termin termin)
        {
            broker.OpenConnection();
            broker.SaveTermin(termin);
            broker.CloseConnection();
        }
    }
}
