using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Bolnica : IEntity
    {
        public int SifraBolnice { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }

        public string TableName => throw new NotImplementedException();

        public string InsertValues => throw new NotImplementedException();

        public override string ToString()
        {
            return $"{Naziv}, {Adresa}";
        }
    }
}