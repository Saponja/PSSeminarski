using BrokerDB;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Storage.Implementation
{
    public class StorageKorisnik : IStorageKorisnici
    {
        private Broker broker;

        public StorageKorisnik()
        {
            broker = new Broker();
        }
        public List<Korisnik> GetAll()
        {
            try
            {
                broker.OpenConnection();
                return broker.GetAllKorisnici();

            }
            finally
            {
                broker.CloseConnection();
            }
            
        }
    }
}
