using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public interface IStorageVrstaPregleda
    {
        List<VrstaPregleda> GetAll();
        void Save(VrstaPregleda pregled);
    }
}
