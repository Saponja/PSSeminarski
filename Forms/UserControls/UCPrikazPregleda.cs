using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControllerB;
using Domain;

namespace Forms.UserControls
{
    public partial class UCPrikazPregleda : UserControl
    {
        private static List<VrstaPregleda> osnovnaLista = new List<VrstaPregleda>();
        private static List<VrstaPregleda> listaKojaSeMenja = new List<VrstaPregleda>();
        //private static List<VrstaPregleda> osnovnaLista = Communication.Communication.Instance.PrikaziPreglede();
        //private static List<VrstaPregleda> listaKojaSeMenja = osnovnaLista;
        public UCPrikazPregleda()
        {
            InitializeComponent();
            osnovnaLista = Communication.Communication.Instance.PrikaziPreglede();
            listaKojaSeMenja = osnovnaLista;
            dgvPregledi.DataSource = osnovnaLista;
        }

        public UCPrikazPregleda(List<VrstaPregleda> lista)
        {
            InitializeComponent();
            dgvPregledi.DataSource = lista;
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            listaKojaSeMenja = (List<VrstaPregleda>)dgvPregledi.DataSource;
            if (!string.IsNullOrWhiteSpace(txtLekar.Text))
            {
                listaKojaSeMenja = listaKojaSeMenja.Where(p => p.Lekar.ToString() == txtLekar.Text).ToList();
            }
            if (!string.IsNullOrWhiteSpace(txtOblast.Text))
            {
                listaKojaSeMenja = listaKojaSeMenja.Where(p => p.Oblast == txtOblast.Text).ToList();
            }
            KreirajUC(listaKojaSeMenja);
        }

        //KreirajUCPrikaz zajednicki za ovo i za prikaz pacijenata u helpersima
        private void KreirajUC(List<VrstaPregleda> lista)
        {
            this.Controls.Clear();
            UCPrikazPregleda ucPrikaz = new UCPrikazPregleda(lista);
            ucPrikaz.Parent = this;
            ucPrikaz.Dock = DockStyle.Fill;
        }

        private void btnResetuj_Click(object sender, EventArgs e)
        {
            KreirajUC(Communication.Communication.Instance.PrikaziPreglede());
        }
    }
}
