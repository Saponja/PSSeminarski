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
using SystemOperations;
using SystemOperations.SODijagnoze;
using SystemOperations.SOLekar;
using SystemOperations.SOPacijent;
using SystemOperations.SOPregled;
using SystemOperations.SOTermin;
using SystemOperations.SOTip;

namespace ControllerB
{
    public class Controller
    {
        private IStorageKorisnici storageKorisnici;
        private IStoragePacijent storagePacijent;
        private IStorageLekari storageLekari;
        private IStorageVrstaPregleda storageVrstaPregleda;
        private SystemOperationsBase so;

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

        public void SacuvajDijagnoze(List<Dijagnoza> dijagnoze)
        {
            so = new SacuvajDijagnozeSO();
            so.ExecuteTemplate(entities: dijagnoze.Cast<IEntity>().ToList());
            //repository.SaveMore(dijagnoze.Cast<IEntity>().ToList());
        }


        public void SacuvajPacijenta(Pacijent pacijent)
        {
            
            so = new SacuvajPacijentaSO();
            pacijent.PacijentID = repository.GetNewId(new Pacijent());
            so.ExecuteTemplate(entity: pacijent);
            //repository.Save(pacijent);

        }

        public List<Pacijent> PrikaziPacijente()
        {
            so = new PrikaziPacijenteSO();
            so.ExecuteTemplate(entity : new Pacijent());
            return (List<Pacijent>)so.Result;
            //return repository.GetAll(new Pacijent()).Cast<Pacijent>().ToList();
        }

        public void ZakazivanjeTermina(List<Termin> termini)
        {
            so = new SacuvajTerminSO();
            so.ExecuteTemplate(entities: termini.Cast<IEntity>().ToList());
            //repository.SaveMore(termini.Cast<IEntity>().ToList());
            
        }

        public void DeletePacijent(Pacijent pacijent, int id)
        {
            so = new ObrisiPacijentaSO();
            so.ExecuteTemplate(entity: pacijent);
            //repository.Delete(pacijent, id);
        }

        public List<Lekar> PrikaziLekare()
        {
            so = new PrikazLekaraSO();
            so.ExecuteTemplate(entity: new Lekar());
            return (List<Lekar>)so.Result;
            //return repository.GetAll(new Lekar()).Cast<Lekar>().ToList();
        }

        public void SacuvajVrstuPregleda(VrstaPregleda pregled)
        {
            so = new SacuvajPregledSO();
            pregled.PregledID = repository.GetNewId(pregled);
            so.ExecuteTemplate(entity: pregled);
            //repository.Save(pregled);
        }

        public List<VrstaPregleda> prikaziPreglede()
        {
            so = new PrikazPregledaSO();
            so.ExecuteTemplate(entity: new VrstaPregleda());
            return (List<VrstaPregleda>)so.Result;
            //return repository.GetAll(new VrstaPregleda()).Cast<VrstaPregleda>().ToList();
        }



        public List<Termin> PrikaziTermine()
        {
            so = new PrikazTerminaSO();
            so.ExecuteTemplate(entity: new Termin());
            return (List<Termin>)so.Result;
            //return repository.GetAll(new Termin()).Cast<Termin>().ToList();
        }

        public List<TipDijagnoze> PrikazTipa()
        {
            so = new PrikazTipaSO();
            so.ExecuteTemplate(entity: new TipDijagnoze());
            return (List<TipDijagnoze>)so.Result;
            //return repository.GetAll(new TipDijagnoze()).Cast<TipDijagnoze>().ToList();
        }

        public void SacuvajTermine(List<Termin> termini)
        {
            storageTermin.SaveMore(termini);
        }
        public List<DateTime> VratiVremeTermina(Lekar lekar)
        {
            return storageTermin.GetVremeTermina(lekar);
        }

        public List<Dijagnoza> GetDijagnoze()
        {
            return storageDijagnoza.Get();
        }

        public List<DateTime> VratiVremeTermina()
        {
            throw new NotImplementedException();
        }

        public void SacuvajTermin(Termin termin)
        {
            storageTermin.Save(termin);
        }
    }
}
