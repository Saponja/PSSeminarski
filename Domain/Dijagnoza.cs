using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Dijagnoza
    {
        public DateTime Datum { get; set; }
        public TipDijagnoze TipDijagnoze { get; set; }
        public Pacijent Pacijent { get; set; }

    }
}
