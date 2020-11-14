using BrokerDB;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Implementation
{
    public class StorageVrstaPregleda : IStorageVrstaPregleda
    {

        private Broker broker;

        public StorageVrstaPregleda()
        {
            broker = new Broker();
        }
        public List<VrstaPregleda> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(VrstaPregleda pregled)
        {
            broker.OpenConnection();
            broker.SaveVrstaPregleda(pregled);
            broker.CloseConnection();
        }
    }
}
