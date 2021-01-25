using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.SOKorisnik
{
    public class PrijavaKorisnikaSO : SystemOperationsBase
    {
        public override void ExecuteOperation(IEntity entity)
        {
            List<Korisnik> korisnici = broker.GetAll(entity).Cast<Korisnik>().ToList();
            Korisnik korisnik = (Korisnik)entity;

            foreach (Korisnik k in korisnici)
            {
                if (k.Username == korisnik.Username && k.Password == korisnik.Password)
                {
                    Result = k;
                    return;
                }
            }

            Result = null;

        }
    }
}
