using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Domain;
using Forms.Communication;

namespace Forms
{
    public class MainController
    {
        
        public MainController()
        {
             
        }



        public void Connect()
        {
            try
            {
                Communication.Communication.Instance.Connect();
            }
            catch (SocketException)
            {
                MessageBox.Show("Greska pri povezivanju sa serverom");
                Environment.Exit(0);
            }
            
        }


    }
}
