using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Pacijent
    {
        public int PacijentID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DaumRodjenja { get; set; }
        public bool Hitan { get; set; }
        public string Anamneza { get; set; }
        public Bolnica Bolnica { get; set; }

        public override bool Equals(object obj)
        {
            Pacijent p = obj as Pacijent;

            if(p != null && p.PacijentID == PacijentID)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }

        public Pacijent Self { get { return this; } }


    }
}
