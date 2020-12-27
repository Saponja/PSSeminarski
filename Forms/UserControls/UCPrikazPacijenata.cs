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
    public partial class UCPrikazPacijenata : UserControl
    {
        private static List<Pacijent> osnovnaLista = Controller.Instance.PrikaziPacijente();
        private static List<Pacijent> listaKojaSeMenja = osnovnaLista;
        public UCPrikazPacijenata()
        {
            InitializeComponent();
            dgvPacijenti.DataSource = Controller.Instance.PrikaziPacijente();
        }

        public UCPrikazPacijenata(List<Pacijent> lista)
        {
            InitializeComponent();
            dgvPacijenti.DataSource = lista;
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            listaKojaSeMenja = (List<Pacijent>)dgvPacijenti.DataSource;

            if (!string.IsNullOrWhiteSpace(txtId.Text) && Int32.TryParse(txtId.Text, out int id))
            {
                listaKojaSeMenja = listaKojaSeMenja.Where(p => p.PacijentID == id).ToList();
            }

            if (!string.IsNullOrWhiteSpace(txtBolnica.Text))
            {
                listaKojaSeMenja = listaKojaSeMenja.Where(p => p.Bolnica.Naziv == txtBolnica.Text).ToList();
            }

            if (rbDa.Checked)
            {
                listaKojaSeMenja = listaKojaSeMenja.Where(p => p.Hitan == true).ToList();
            }

            if (rbNe.Checked)
            {
                listaKojaSeMenja = listaKojaSeMenja.Where(p => p.Hitan == false).ToList();
            }

            KreirajUC(listaKojaSeMenja);

        }

        private void btnResetuj_Click(object sender, EventArgs e)
        {
            KreirajUC(Controller.Instance.PrikaziPacijente());
        }

        private void KreirajUC(List<Pacijent> lista)
        {
            this.Controls.Clear();
            UCPrikazPacijenata ucPrikaz = new UCPrikazPacijenata(lista);
            ucPrikaz.Parent = this;
            ucPrikaz.Dock = DockStyle.Fill;
        }

        private void KreirajUC(UserControl user)
        {
            this.Controls.Clear();
            user.Parent = this;
            user.Dock = DockStyle.Fill;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if(dgvPacijenti.SelectedRows.Count < 1)
            {
                MessageBox.Show("Morate da izaberete red");
                return;
            }
            DialogResult result = MessageBox.Show("", "Da li ste sigurni da hocete da izbriste pacijente?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                List<int> listaZaBrisanje = new List<int>();
                listaKojaSeMenja = (List<Pacijent>)dgvPacijenti.DataSource;
                osnovnaLista = Controller.Instance.PrikaziPacijente();
                foreach (DataGridViewRow item in dgvPacijenti.SelectedRows)
                {
                    int id = (int)item.Cells[0].Value;
                    listaZaBrisanje.Add(id);
                }
                int brojac = 0;
                foreach (int i in listaZaBrisanje)
                {
                    //brojaci??? 
                    Pacijent pacijent = osnovnaLista.Find(p => p.PacijentID == i);
                    if (listaKojaSeMenja.Contains(pacijent))
                    {
                        brojac = brojac + 1;
                        listaKojaSeMenja.Remove(pacijent);
                    }
                    Controller.Instance.DeletePacijent(pacijent);
                    //osnovnaLista.Remove(pacijent);
                }
                osnovnaLista = Controller.Instance.PrikaziPacijente();

                if (brojac == listaZaBrisanje.Count)
                {
                    KreirajUC(listaKojaSeMenja);
                }
                else
                {
                    KreirajUC(osnovnaLista);
                }

            }
            else if (result == DialogResult.No)
            {
                
            }

           
        }

        private void dgvPacijenti_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            KreirajUC(new UCKarton((Pacijent)dgvPacijenti.SelectedRows[0].DataBoundItem));
        }
    }
}
