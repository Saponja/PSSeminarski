using ControllerB;
using Forms.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void KreirajUC(UserControl userControl)
        {
            pnlGlavni.Controls.Clear();
            userControl.Parent = pnlGlavni;
            userControl.Dock = DockStyle.Fill;
        }

        private void unesiPacijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KreirajUC(new UCUnosPacijenta());
        }



        private void unesiPregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KreirajUC(new UCUnosPregleda());
 
        }

        private void pacijentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KreirajUC(new UCPrikazPacijenata());

        }

        private void preglediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KreirajUC(new UCPrikazPregleda());
        }
    }
}
