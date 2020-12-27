using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public interface IStorageDijagnoza
    {
        void Insert(Dijagnoza dijagnoza);
        List<Dijagnoza> Get();
        List<TipDijagnoze> GetTip();
        void SaveMoreDijagnoze(List<Dijagnoza> dijagnoze);
    }
}
