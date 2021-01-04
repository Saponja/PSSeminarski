using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Dijagnoza
    {
        public DateTime Datum { get; set; }
        [Browsable(false)]
        public int DijagnozaId { get; set; }
        [Browsable(false)]
        public int PacijentId { get; set; }

        public TipDijagnoze TipDijagnoze { get; set; }
        public Pacijent Pacijent { get; set; }

    }
}
