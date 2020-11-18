﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class VrstaPregleda
    {
        public int PregledID { get; set; }
        public string Naziv { get; set; }
        public string Oblast { get; set; }
        public Lekar Lekar { get; set; }

        public override string ToString()
        {
            return $"{Naziv}";
        }
    }
}
