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
        public ClientHandler(Socket client)
        {
            this.client = client;
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
                    break;
                case Operation.PrikazPacijenata:
                    response.Result = Controller.Instance.PrikaziPacijente();
                    break;
                case Operation.PrikazPregleda:
                    response.Result = Controller.Instance.prikaziPreglede();
                    break;
                case Operation.UnosDijagnoze:
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
                    break;
                case Operation.ZakazivanjeTermina:
                    break;
                case Operation.BrisanjePacijenta:
                    try
                    {
                        Controller.Instance.DeletePacijent((Pacijent)request.Data);
                        response.IsSuccessful = true;
                    }
                    catch (Exception ex)
                    {
                        response.IsSuccessful = false;
                        response.Error = ex.Message;

                    }
                    
                    break;
                default:
                    break;
            }

            return response;
        }
    }
}
