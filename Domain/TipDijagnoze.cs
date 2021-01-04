using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class TipDijagnoze
    {
        public int DijagnozaID { get; set; }
        public string Naziv { get; set; }

        public override string ToString()
        {
            return $"{Naziv}";
        }
    }
}
