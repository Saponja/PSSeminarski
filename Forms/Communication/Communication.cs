using Common;
using Domain;
using Forms.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Communication
{
    public class Communication
    {
        private static Communication instance;
        public Korisnik LoggedInKorisnik { get; set; }
        private Socket socket;
        private Sender sender;
        private Receiver receiver;

        internal List<VrstaPregleda> PrikaziPreglede()
        {
            Request request = new Request { Operation = Operation.PrikazPregleda };
            Send(sender, request);
            Response response = Receive(receiver);
            //sender.Send(request);
            //Response response = receiver.Receive();
            return (List<VrstaPregleda>)response.Result;
        }

        internal List<Bolnica> PrikaziBolnice()
        {
            Request request = new Request { Operation = Operation.PrikazBolnica };
            Send(sender, request);
            Response response = Receive(receiver);
            //sender.Send(request);
            //Response response = receiver.Receive();
            return (List<Bolnica>)response.Result;
        }

        internal DateTime SledeciTermin(string cond)
        {
            Request request = new Request { Operation = Operation.SledeciTermin, Data = cond };
            Send(sender, request);
            Response response = Receive(receiver);
            //sender.Send(request);
            //Response response = receiver.Receive();
            return (DateTime)response.Result;
        }

        internal List<Dijagnoza> PrikaziDijagnoze()
        {
            Request request = new Request { Operation = Operation.PrikazDijagnoza };
            Send(sender, request);
            Response response = Receive(receiver);
            //sender.Send(request);
            //Response response = receiver.Receive();
            return (List<Dijagnoza>)response.Result;
        }

        internal void Logout()
        {
            Request request = new Request { Operation = Operation.Logout, Data = LoggedInKorisnik};
            Send(sender, request);
            Response response = Receive(receiver);
        }

        internal List<TipDijagnoze> PrikaziTip()
        {
            Request request = new Request { Operation = Operation.PrikazTipa };
            Send(sender, request);
            Response response = Receive(receiver);
            //sender.Send(request);
            //Response response = (Response)receiver.Receive();
            return (List<TipDijagnoze>) response.Result;

        }

        internal List<Termin> PrikaziTermine()
        {
            Request request = new Request { Operation = Operation.PrikazTermina };
            Send(sender, request);
            Response response = Receive(receiver);
            //sender.Send(request);
            //Response response = receiver.Receive();
            return (List<Termin>)response.Result;
        }

        internal bool SacuvajDijagnozu(List<Dijagnoza> dijagnoze)
        {
            Request request = new Request { Operation = Operation.UnosDijagnoze, Data = dijagnoze };
            Send(sender, request);
            Response response = Receive(receiver);
            return response.IsSuccessful;
            //sender.Send(request);
            //Response response = receiver.Receive();

        }

        internal List<Lekar> PrikaziLekare()
        {
            Request request = new Request { Operation = Operation.PrikazLekara};
            Send(sender, request);
            Response response = Receive(receiver);
            //sender.Send(request);
            //Response response = receiver.Receive();
            return (List<Lekar>)response.Result;
        }

        private Communication()
        {
            //socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        }

        public static Communication Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Communication();
                }
                return instance;
            }
        }

        internal List<Pacijent> PrikaziPacijente()
        {
            Request request = new Request { Operation = Operation.PrikazPacijenata };
            Send(sender, request);
            Response response = Receive(receiver);
            //sender.Send(request);
            //Response response = receiver.Receive();
            return (List<Pacijent>)response.Result;
        }

        internal bool SacuvajVrstuPregleda(VrstaPregleda pregled)
        {
            Request request = new Request { Operation = Operation.UnosPregleda, Data = pregled };
            Send(sender, request);
            Response response = Receive(receiver);
            return response.IsSuccessful;
            //sender.Send(request);
            //Response response = receiver.Receive();
        }

        internal bool SacuvajPacijenta(Pacijent pacijent)
        {
            Request request = new Request { Operation = Operation.UnosPacijenta, Data = pacijent };
            Send(sender, request);
            Response response = Receive(receiver);
            return response.IsSuccessful;
            //sender.Send(request);
            //Response response = receiver.Receive();
            
        }

        public Korisnik Login(string username, string password)
        {
            Request request = new Request { Operation = Operation.Login, Data = new Korisnik { Username = username, Password = password } };
            Send(sender, request);
            //sender.Send(request);
            //Response response = receiver.Receive();
            Response response = Receive(receiver);
            LoggedInKorisnik = (Korisnik)response.Result;
            return (Korisnik)response.Result;
        }


        public void Connect()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9999);
            sender = new Sender(socket);
            receiver = new Receiver(socket);
        }

        internal bool DeletePacijent(Pacijent pacijent, int id)
        {
            Request request = new Request { Operation = Operation.BrisanjePacijenta, Data = pacijent };
            Send(sender, request);
            Response response = Receive(receiver);
            //sender.Send(request);
            //Response response = receiver.Receive();
            return response.IsSuccessful;
        }

        internal bool SacuvajTermine(List<Termin> termini)
        {
            Request request = new Request { Operation = Operation.ZakazivanjeTermina, Data = termini };
            Send(sender, request);
            Response response = Receive(receiver);
            return response.IsSuccessful;
            //sender.Send(request);
            //Response response = receiver.Receive();
        }

        internal List<DateTime> VratiVremeTermina(string cond)
        {
            Request request = new Request { Operation = Operation.VratiVremeTermina, Data = cond };
            Send(sender, request);
            Response response = Receive(receiver);
            //sender.Send(request);
            //Response response = receiver.Receive();
            return (List<DateTime>)response.Result;

        }

        private void Send(Sender sender, Request request)
        {
            try
            {
                sender.Send(request);
            }
            catch (IOException)
            {
                throw new ServerException();
            }
            catch(SocketException)
            {
                throw new ServerException();
            }
        }

        private Response Receive(Receiver receiver)
        {
            try
            {
                return receiver.Receive();
            }
            catch (IOException)
            {
                throw new ServerException();
            }
            catch(SocketException)
            {
                throw new ServerException();
            }
        }
    }
}
