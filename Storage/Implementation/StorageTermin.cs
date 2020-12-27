using BrokerDB;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public List<DateTime> GetVremeTermina(Lekar lekar)
        {
            try
            {
                broker.OpenConnection();
                return broker.GetVremeTermina(lekar);

            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public void SaveMore(List<Termin> termini)
        {
            broker.OpenConnection();
            broker.BeginTransaction();

            try
            {
                foreach (Termin termin in termini)
                {
                    broker.SaveTermin(termin);
                }

                broker.Commit();

            }
            catch(Exception ex)
            {
                broker.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public DateTime SledeciTermin(int pacijentId)
        {
            try
            {
                broker.OpenConnection();
                return broker.SledeciTermin(pacijentId);

            }
            finally
            {
                broker.CloseConnection();
            }
        }
    }
}
