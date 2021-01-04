using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Lekar
    {
        public int LekarID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Specijalizacija { get; set; }
        public Bolnica Bolnica { get; set; }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }

    }
}
