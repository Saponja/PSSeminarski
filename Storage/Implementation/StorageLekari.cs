using BrokerDB;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Implementation
{
    public class StorageLekari : IStorageLekari
    {
        private Broker broker;
        public StorageLekari()
        {
            broker = new Broker();
        }
        public List<Lekar> GetAll()
        {
            try
            {
                broker.OpenConnection();
                return broker.GetAllLekari();
            }
            finally
            {
                broker.CloseConnection();
            }
            
        }
    }
}
