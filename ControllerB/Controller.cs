using Domain;
using Storage;
using Storage.Implementation;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControllerB
{
    public class Controller
    {
        private IStorageKorisnici storageKorisnici;
        private IStoragePacijent storagePacijent;
        private IStorageLekari storageLekari;
        private IStorageVrstaPregleda storageVrstaPregleda;
        private IStorageTermin storageTermin;
        public Korisnik LoggedInKorisnik { get; set; }

        private static Controller controller;

        public static Controller Instance
        {
            get
            {
                if(controller == null)
                {
                    controller = new Controller();
                }
                return controller;
            }
        }

        private Controller()
        {
            storageKorisnici = new StorageKorisnik();
            storagePacijent = new StoragePacijent();
            storageLekari = new StorageLekari();
            storageVrstaPregleda = new StorageVrstaPregleda();
            storageTermin = new StorageTermin();
            
        }

        public Korisnik Prijava(string username, string password)
        {
            List<Korisnik> korisnici = storageKorisnici.GetAll();
         
            foreach(Korisnik k in korisnici)
            {
                if(k.Username == username && k.Password == password)
                {
                    LoggedInKorisnik = k;
                    return k;
                }
            }

            throw new Exception("Korisnik sa datim username-om ili password-om ne postoji");
        }

        public void SacuvajTermin(Termin termin)
        {
            storageTermin.Save(termin);
        }

        public void SacuvajPacijenta(Pacijent pacijent)
        {
            storagePacijent.Save(pacijent);
        }

        public List<Pacijent> PrikaziPacijente()
        {
            return storagePacijent.GetAll();
        }

        public void DeletePacijent(Pacijent pacijent)
        {
            storagePacijent.Delete(pacijent);
        }

        public List<Lekar> PrikaziLekare()
        {
            return storageLekari.GetAll();
        }

        public void SacuvajVrstuPregleda(VrstaPregleda pregled)
        {
            storageVrstaPregleda.Save(pregled);
        }

        public List<VrstaPregleda> prikaziPreglede()
        {
            return storageVrstaPregleda.GetAll();
        }

        public List<DateTime> VratiVremeTermina()
        {
            return storageTermin.GetVremeTermina();
        }

        public List<Termin> PrikaziTermine()
        {
            return storageTermin.GetAll();
        }



        
    }
}
