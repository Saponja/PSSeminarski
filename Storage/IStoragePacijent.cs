using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public interface IStoragePacijent
    {
        List<Pacijent> GetAll();

        void Save(Pacijent pacijent);

        void Delete(Pacijent pacijent);

    }
}
