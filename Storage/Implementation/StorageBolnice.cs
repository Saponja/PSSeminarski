using BrokerDB;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Implementation
{
    public class StorageBolnice : IStorageBolnice
    {
        private Broker broker;
        public StorageBolnice()
        {
            broker = new Broker();
        }
        public List<Bolnica> GetAll()
        {
            try
            {
                broker.OpenConnection();
                return broker.GetAllBolnice();
            }
            finally
            {
                broker.CloseConnection();
            }
            
        }
    }
}
