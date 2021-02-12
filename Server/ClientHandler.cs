using Common;
using ControllerB;
using Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        private Socket client;
        private Server server;
        private bool kraj = false;
        public ClientHandler(Socket client, Server server)
        {
            this.client = client;
            this.server = server;
        }

        public void StartHandler()
        {
            try
            {
                NetworkStream stream = new NetworkStream(client);
                BinaryFormatter formatter = new BinaryFormatter();
                while (!kraj)
                {
                    Request request = (Request)formatter.Deserialize(stream);
                    Response response = ProcessRequest(request);
                    formatter.Serialize(stream, response); 
                }
                client.Close();
            }
            catch (IOException ex)
            {

                Console.WriteLine("Klijent je prekinuo vezu");
            }
            
        }

        private Response ProcessRequest(Request request)
        {
            Response response = new Response();
            switch (request.Operation)
            {
                case Operation.Login:
                    Korisnik korisnik = (Korisnik)request.Data;
                    response.Result = Controller.Instance.Prijava(korisnik.Username, korisnik.Password);

                    if (server.Users.Any(u => u.Username == ((Korisnik)response.Result).Username))
                    {
                        response.Result = new Korisnik { KorisnikId = -1 };
                    }

                    if ((Korisnik)response.Result != null && ((Korisnik)response.Result).KorisnikId != -1)
                    {
                        server.Users.Add((Korisnik)response.Result);
                    }

                    break;
                case Operation.PrikazPacijenata:
                    response.Result = Controller.Instance.PrikaziPacijente();
                    break;
                case Operation.PrikazPregleda:
                    response.Result = Controller.Instance.prikaziPreglede();
                    break;
                case Operation.UnosDijagnoze:

                    List<Dijagnoza> dijagnoze = (List<Dijagnoza>)request.Data;
                    if (Controller.Instance.SacuvajDijagnoze(dijagnoze))
                    {
                        response.IsSuccessful = true;
                    }
                    else
                    {
                        response.IsSuccessful = false;
                    }



                    break;
                case Operation.UnosPacijenta:
                    Pacijent pacijent = (Pacijent)request.Data;
                    if (Controller.Instance.SacuvajPacijenta(pacijent))
                    {
                        response.IsSuccessful = true;
                    }
                    else
                    {
                        response.IsSuccessful = false;
                    }

                    break;
                case Operation.UnosPregleda:
                    VrstaPregleda pregled = (VrstaPregleda)request.Data;

                    if (Controller.Instance.SacuvajVrstuPregleda(pregled))
                    {
                        response.IsSuccessful = true;
                    }
                    else
                    {
                        response.IsSuccessful = false;
                    }

                    break;
                case Operation.ZakazivanjeTermina:
                    List<Termin> termini = (List<Termin>)request.Data;

                    if (Controller.Instance.ZakazivanjeTermina(termini))
                    {
                        response.IsSuccessful = true;

                    }
                    else
                    {
                        response.IsSuccessful = false;
                    }
                    break;
                case Operation.BrisanjePacijenta:

                    Pacijent pacijentbr = (Pacijent)request.Data;
                    bool scs = Controller.Instance.DeletePacijent(pacijentbr, pacijentbr.PacijentID);
                    if (scs)
                    {
                        response.IsSuccessful = true;
                    }
                    else
                    {
                        response.IsSuccessful = false;

                    }



                    break;
                case Operation.PrikazLekara:
                    response.Result = Controller.Instance.PrikaziLekare();
                    break;
                case Operation.PrikazTermina:
                    response.Result = Controller.Instance.PrikaziTermine();
                    break;
                case Operation.PrikazTipa:
                    response.Result = Controller.Instance.PrikazTipa();
                    break;
                case Operation.VratiVremeTermina:
                    response.Result = Controller.Instance.VratiVremeTermina(request.Data.ToString());
                    break;
                case Operation.PrikazDijagnoza:
                    response.Result = Controller.Instance.PrikaziDijagnoze();
                    break;
                case Operation.SledeciTermin:
                    response.Result = Controller.Instance.SledeciTermin(request.Data.ToString());
                    break;
                case Operation.PrikazBolnica:
                    response.Result = Controller.Instance.PrikaziBolnice();
                    break;
                case Operation.Logout:
                    Korisnik loggedInKorisnik = (Korisnik)request.Data;
                    foreach (Korisnik k in server.Users)
                    {
                        if(loggedInKorisnik.KorisnikId == k.KorisnikId)
                        {
                            server.Users.Remove(k);
                            break;
                        }
                    }
                    response.Result = new object { };
                    kraj = true;
                    break;
                default:
                    break;
            }

            return response;
        }

        internal void Stop()
        {
            kraj = true;
            client.Close();
        }
    }
}
