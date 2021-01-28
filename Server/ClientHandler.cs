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
                while (true)
                {
                    Request request = (Request)formatter.Deserialize(stream);
                    Response response = ProcessRequest(request);
                    formatter.Serialize(stream, response);
                }
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

                    if ((Korisnik)response.Result != null)
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
                    try
                    {
                        List<Dijagnoza> dijagnoze = (List<Dijagnoza>)request.Data;
                        Controller.Instance.SacuvajDijagnoze(dijagnoze);
                        response.IsSuccessful = true;
                    }
                    catch (Exception)
                    {
                        response.IsSuccessful = false;
                        throw;
                    }
                    break;
                case Operation.UnosPacijenta:
                    try
                    {
                        Pacijent pacijent = (Pacijent)request.Data;
                        Controller.Instance.SacuvajPacijenta(pacijent);
                        response.IsSuccessful = true;
                    }
                    catch (Exception)
                    {
                        response.IsSuccessful = false;
                        throw;
                    }
                    break;
                case Operation.UnosPregleda:
                    try
                    {
                        VrstaPregleda pregled = (VrstaPregleda)request.Data;
                        Controller.Instance.SacuvajVrstuPregleda(pregled);
                        response.IsSuccessful = true;
                    }
                    catch (Exception)
                    {
                        response.IsSuccessful = false;
                        throw;
                    }

                    break;
                case Operation.ZakazivanjeTermina:
                    try
                    {
                        List<Termin> termini = (List<Termin>)request.Data;
                        Controller.Instance.ZakazivanjeTermina(termini);
                        response.IsSuccessful = true;
                    }
                    catch (Exception ex)
                    {
                        response.IsSuccessful = false;
                        response.Error = ex.Message;

                    }
                    break;
                case Operation.BrisanjePacijenta:
                    try
                    {
                        Pacijent pacijent = (Pacijent)request.Data;
                        bool scs = Controller.Instance.DeletePacijent(pacijent, pacijent.PacijentID);
                        if (scs)
                        {
                            response.IsSuccessful = true;
                        }
                        else
                        {
                            response.IsSuccessful = false;

                        }
                    }
                    catch (Exception ex)
                    {
                        response.IsSuccessful = false;
                        response.Error = ex.Message;

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
                default:
                    break;
            }

            return response;
        }

        internal void Stop()
        {
            client.Close();
        }
    }
}
