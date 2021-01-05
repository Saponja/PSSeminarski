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

        private IRepository repository;

        private static object _lock = new object();

        public List<TipDijagnoze> GetTip()
        {
            return storageDijagnoza.GetTip();
        }

        private IStorageTermin storageTermin;
        private IStorageDijagnoza storageDijagnoza;
        public Korisnik LoggedInKorisnik { get; set; }

        private static Controller controller;

        public DateTime SledeciTermin(int pacijentID)
        {
            return storageTermin.SledeciTermin(pacijentID);
        }

        public static Controller Instance
        {
            get
            {
                if(controller == null)
                {
                    lock (_lock)
                    {
                        if (controller == null)
                        {
                            controller = new Controller();
                        }
                    }
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
            storageDijagnoza = new StorageDijagnoza();

            repository = new Repository();


        }

        public void SaveMoreDijagnoze(List<Dijagnoza> dijagnoze)
        {
            storageDijagnoza.SaveMoreDijagnoze(dijagnoze);
        }

        public void SacuvajDijagnoze(List<Dijagnoza> dijagnoze)
        {
            repository.SaveMore(dijagnoze.Cast<IEntity>().ToList());
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

        public List<DateTime> VratiVremeTermina()
        {
            throw new NotImplementedException();
        }

        public void SacuvajTermin(Termin termin)
        {
            storageTermin.Save(termin);
        }

        public void SacuvajPacijenta(Pacijent pacijent)
        {
            //storagePacijent.Save(pacijent);
            pacijent.PacijentID = repository.GetNewId(new Pacijent());
            repository.Save(pacijent);
        }

        public List<Pacijent> PrikaziPacijente()
        {
            return repository.GetAll(new Pacijent()).Cast<Pacijent>().ToList();
        }

        public void ZakazivanjeTermina(List<Termin> termini)
        {

            repository.SaveMore(termini.Cast<IEntity>().ToList());
            //foreach (Termin termin in termini)
            //{
            //    repository.Save(termin);
            //}
        }

        public void DeletePacijent(Pacijent pacijent, int id)
        {
            repository.Delete(pacijent, id);
        }

        public List<Lekar> PrikaziLekare()
        {
            return repository.GetAll(new Lekar()).Cast<Lekar>().ToList();
        }

        public void SacuvajVrstuPregleda(VrstaPregleda pregled)
        {
            pregled.PregledID = repository.GetNewId(pregled);
            repository.Save(pregled);
        }

        public List<VrstaPregleda> prikaziPreglede()
        {
            return repository.GetAll(new VrstaPregleda()).Cast<VrstaPregleda>().ToList();
        }

        public List<DateTime> VratiVremeTermina(Lekar lekar)
        {
            return storageTermin.GetVremeTermina(lekar);
        }

        public List<Termin> PrikaziTermine()
        {
            return repository.GetAll(new Termin()).Cast<Termin>().ToList();
        }

        public List<TipDijagnoze> PrikazTipa()
        {
            return repository.GetAll(new TipDijagnoze()).Cast<TipDijagnoze>().ToList();
        }

        public void SacuvajTermine(List<Termin> termini)
        {
            storageTermin.SaveMore(termini);
        }

        public List<Dijagnoza> GetDijagnoze()
        {
            return storageDijagnoza.Get();
        }
    }
}
