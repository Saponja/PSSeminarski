﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Korisnik
    {
        public int KorisnikId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
