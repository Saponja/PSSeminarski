using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        public FrmServer()
        {
            InitializeComponent();
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
            try
            {
                Server server = new Server();
                server.Start();
                Thread thread = new Thread(server.Listen);
                thread.Start();

            }
            catch (SocketException se)
            {

                MessageBox.Show(se.Message);
            }
        }
    }
}
