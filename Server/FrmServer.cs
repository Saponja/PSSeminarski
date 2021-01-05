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

        private Server server = new Server();
        
        public FrmServer()
        {
            InitializeComponent();
            btnZaustavi.Enabled = false;
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPokerni_Click(object sender, EventArgs e)
        {
            try
            {
                
                server.Start();
                Thread thread = new Thread(server.Listen);
                thread.Start();
                btnPokerni.Enabled = false;
                btnZaustavi.Enabled = true;

            }
            catch (SocketException se)
            {

                MessageBox.Show(se.Message);
            }
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            server.Stop();
            btnPokerni.Enabled = true;
            btnZaustavi.Enabled = false;
        }
    }
}
