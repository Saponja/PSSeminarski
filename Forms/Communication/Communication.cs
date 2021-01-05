using Common;
using Domain;
using System;
using System.Collections.Generic;
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
        private Socket socket;
        private Sender sender;
        private Receiver receiver;

        internal List<VrstaPregleda> PrikaziPreglede()
        {
            Request request = new Request { Operation = Operation.PrikazPregleda };
            sender.Send(request);
            Response response = receiver.Receive();
            return (List<VrstaPregleda>)response.Result;
        }

        internal List<TipDijagnoze> PrikaziTip()
        {
            Request request = new Request { Operation = Operation.PrikazTipa };
            sender.Send(request);
            Response response = (Response)receiver.Receive();
            return (List<TipDijagnoze>) response.Result;

        }

        internal List<Termin> PrikaziTermine()
        {
            Request request = new Request { Operation = Operation.PrikazTermina };
            sender.Send(request);
            Response response = receiver.Receive();
            return (List<Termin>)response.Result;
        }

        internal void SacuvajDijagnozu(List<Dijagnoza> dijagnoze)
        {
            Request request = new Request { Operation = Operation.UnosDijagnoze, Data = dijagnoze };
            sender.Send(request);
            Response response = receiver.Receive();

        }

        internal List<Lekar> PrikaziLekare()
        {
            Request request = new Request { Operation = Operation.PrikazLekara};
            sender.Send(request);
            Response response = receiver.Receive();
            return (List<Lekar>)response.Result;
        }

        private Communication()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

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
            sender.Send(request);
            Response response = receiver.Receive();
            return (List<Pacijent>)response.Result;
        }

        internal void SacuvajVrstuPregleda(VrstaPregleda pregled)
        {
            Request request = new Request { Operation = Operation.UnosPregleda, Data = pregled };
            sender.Send(request);
            Response response = receiver.Receive();
        }

        internal void SacuvajPacijenta(Pacijent pacijent)
        {
            Request request = new Request { Operation = Operation.UnosPacijenta, Data = pacijent };
            sender.Send(request);
            Response response = receiver.Receive();
            
        }

        public Korisnik Login(string username, string password)
        {
            Request request = new Request { Operation = Operation.Login, Data = new Korisnik { Username = username, Password = password } };
            sender.Send(request);
            Response response = receiver.Receive();
            return (Korisnik)response.Result;
        }


        public void Connect()
        {
            socket.Connect("127.0.0.1", 9999);
            sender = new Sender(socket);
            receiver = new Receiver(socket);
        }

        internal void DeletePacijent(Pacijent pacijent, int id)
        {
            Request request = new Request { Operation = Operation.BrisanjePacijenta, Data = pacijent };
            sender.Send(request);
            Response response = receiver.Receive();
        }

        internal void SacuvajTermine(List<Termin> termini)
        {
            Request request = new Request { Operation = Operation.ZakazivanjeTermina, Data = termini };
            sender.Send(request);
            Response response = receiver.Receive();
        }
    }
}
