using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Termin
    {
        public DateTime DateTime { get; set; }
        public double Cena { get; set; }
        public Pacijent Pacijent { get; set; }
        public VrstaPregleda VrstaPregleda { get; set; }

    }
}
