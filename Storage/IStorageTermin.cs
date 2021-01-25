using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public interface IStorageTermin
    {
        void Save(Termin termin);
        List<Termin> GetAll();
        //List<DateTime> GetVremeTermina(Lekar lekar);
        void SaveMore(List<Termin> termini);

        //DateTime SledeciTermin(int pacijentId);
    }
}
