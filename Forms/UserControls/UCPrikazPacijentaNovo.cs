using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Forms.UserControls
{
    public partial class UCPrikazPacijentaNovo : UserControl
    {
        BindingList<Pacijent> pacijenti = new BindingList<Pacijent>();
        public UCPrikazPacijentaNovo()
        {
            InitializeComponent();
            pacijenti = new BindingList<Pacijent>(Communication.Communication.Instance.PrikaziPacijente());
            dgvPacijenti.DataSource = pacijenti;
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtId.Text) && Int32.TryParse(txtId.Text, out int id))
            {
                pacijenti = new BindingList<Pacijent>(Communication.Communication.Instance.PrikaziPacijenteWhere($"where p.Id = {id}"));
                dgvPacijenti.DataSource = pacijenti;
            }

            if (!string.IsNullOrWhiteSpace(txtBolnica.Text))
            {
                string b = txtBolnica.Text;

                if (b.Equals("Prva") || b.Equals("Druga") || b.Equals("Treca"))
                {
                    pacijenti = new BindingList<Pacijent>(Communication.Communication.Instance.PrikaziPacijenteWhere($"where b.Naziv = '{b}'"));
                    dgvPacijenti.DataSource = pacijenti;
                }
                else
                {
                    MessageBox.Show("Postoje Prva, Druga i Treca bolnica, probajte neku od njih");
                }

            }

            if (rbDa.Checked)
            {
                pacijenti = new BindingList<Pacijent>(Communication.Communication.Instance.PrikaziPacijenteWhere($"where p.Hitan = 1"));
                dgvPacijenti.DataSource = pacijenti;
            }

            if (rbNe.Checked)
            {
                pacijenti = new BindingList<Pacijent>(Communication.Communication.Instance.PrikaziPacijenteWhere($"where p.Hitan = 0"));
                dgvPacijenti.DataSource = pacijenti;
            }
        }

        private void btnResetuj_Click(object sender, EventArgs e)
        {
            pacijenti = new BindingList<Pacijent>(Communication.Communication.Instance.PrikaziPacijente());
            dgvPacijenti.DataSource = pacijenti;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvPacijenti.SelectedRows.Count < 1)
            {
                MessageBox.Show("Morate da izaberete red");
                return;
            }
            DialogResult result = MessageBox.Show("", "Da li ste sigurni da hocete da izbriste pacijente?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Pacijent pacijent = (Pacijent)dgvPacijenti.SelectedRows[0].DataBoundItem;
                if (!Communication.Communication.Instance.DeletePacijent(pacijent, pacijent.PacijentID))
                {
                    MessageBox.Show("Pacijent ima zakazan termin, ili dijagnozu koja je postavljena");

                }
                else
                {
                    MessageBox.Show("Pacijent je uspesno izbrisan");
                    pacijenti = new BindingList<Pacijent>(Communication.Communication.Instance.PrikaziPacijente());
                    dgvPacijenti.DataSource = pacijenti;
                }

            }
        }
    }
}
