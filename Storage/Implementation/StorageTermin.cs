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
            try
            {
                broker.OpenConnection();
                return broker.GetAllTermini();

            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public void Save(Termin termin)
        {
            broker.OpenConnection();
            broker.SaveTermin(termin);
            broker.CloseConnection();
        }

        public List<DateTime> GetVremeTermina()
        {
            try
            {
                broker.OpenConnection();
                return broker.GetVremeTermina();

            }
            finally
            {
                broker.CloseConnection();
            }
        }
    }
}
