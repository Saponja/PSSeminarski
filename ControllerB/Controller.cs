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
using SystemOperations.SOBolnice;
using SystemOperations.SODijagnoze;
using SystemOperations.SOKorisnik;
using SystemOperations.SOLekar;
using SystemOperations.SOPacijent;
using SystemOperations.SOPregled;
using SystemOperations.SOTermin;
using SystemOperations.SOTip;

namespace ControllerB
{
    public class Controller
    {
        
        private SystemOperationsBase so;

        private IRepository repository;

        private static object _lock = new object();

        public Korisnik LoggedInKorisnik { get; set; }

        private static Controller controller;



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
            //storageKorisnici = new StorageKorisnik();
            //storagePacijent = new StoragePacijent();
            //storageLekari = new StorageLekari();
            //storageVrstaPregleda = new StorageVrstaPregleda();
            //storageTermin = new StorageTermin();
            //storageDijagnoza = new StorageDijagnoza();

            repository = new Repository();


        }

        public Korisnik Prijava(string username, string password)
        {
            so = new PrijavaKorisnikaSO();
            Korisnik korisnik = new Korisnik { Username = username, Password = password };
            so.ExecuteTemplate(entity: korisnik);
            Korisnik prijavljen = (Korisnik)so.Result;
            if(prijavljen != null)
            {
                LoggedInKorisnik = prijavljen;
                return prijavljen;
            }

            return null;
        }

        public bool SacuvajDijagnoze(List<Dijagnoza> dijagnoze)
        {
            so = new SacuvajDijagnozeSO();
            so.ExecuteTemplate(entities: dijagnoze.Cast<IEntity>().ToList());
            return so.Successful;
            //repository.SaveMore(dijagnoze.Cast<IEntity>().ToList());
        }

        public DateTime SledeciTermin(string cond)
        {
            so = new SledeciTerminSO(cond);
            so.ExecuteTemplate(entity: new Termin());
            return (DateTime)so.Result;
        }


        public bool SacuvajPacijenta(Pacijent pacijent)
        {
            
            so = new SacuvajPacijentaSO();
            pacijent.PacijentID = repository.GetNewId(new Pacijent());
            so.ExecuteTemplate(entity: pacijent);
            return so.Successful;
            //repository.Save(pacijent);

        }

        public List<Pacijent> PrikaziPacijente()
        {
            so = new PrikaziPacijenteSO();
            so.ExecuteTemplate(entity : new Pacijent());
            return (List<Pacijent>)so.Result;
            //return repository.GetAll(new Pacijent()).Cast<Pacijent>().ToList();
        }

        public bool ZakazivanjeTermina(List<Termin> termini)
        {
            so = new SacuvajTerminSO();
            so.ExecuteTemplate(entities: termini.Cast<IEntity>().ToList());
            return so.Successful;
            //repository.SaveMore(termini.Cast<IEntity>().ToList());
            
        }

        public bool DeletePacijent(Pacijent pacijent, int id)
        {
            so = new ObrisiPacijentaSO();
            so.ExecuteTemplate(entity: pacijent);
            return so.Successful;
            //repository.Delete(pacijent, id);
        }

        public List<Lekar> PrikaziLekare()
        {
            so = new PrikazLekaraSO();
            so.ExecuteTemplate(entity: new Lekar());
            return (List<Lekar>)so.Result;
            //return repository.GetAll(new Lekar()).Cast<Lekar>().ToList();
        }

        public bool SacuvajVrstuPregleda(VrstaPregleda pregled)
        {
            so = new SacuvajPregledSO();
            pregled.PregledID = repository.GetNewId(pregled);
            so.ExecuteTemplate(entity: pregled);
            return so.Successful;
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

        public List<Dijagnoza> PrikaziDijagnoze()
        {
            so = new PrikazDijagnozeSO();
            so.ExecuteTemplate(entity: new Dijagnoza());
            return (List<Dijagnoza>)so.Result;
        }

        public List<DateTime> VratiVremeTermina(string cond = "")
        {
            so = new PrikaziVremeTerminaSO(cond);
            so.ExecuteTemplate(entity : new Termin());
            return (List<DateTime>)so.Result;
        }

        public List<Bolnica> PrikaziBolnice()
        {
            so = new PrikazBolnicaSO();
            so.ExecuteTemplate(entity: new Bolnica());
            return (List<Bolnica>)so.Result;

        }
    }
}
