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
using Forms.Helpers;

namespace Forms.UserControls
{
    public partial class UCUnosPregleda : UserControl
    {
        public UCUnosPregleda()
        {
            InitializeComponent();
            dgvLekari.DataSource = Controller.Instance.PrikaziLekare();
            
        }

        private void dgvLekari_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIme.Text = (string)dgvLekari.SelectedRows[0].Cells[1].Value;
            txtPrezime.Text = (string)dgvLekari.SelectedRows[0].Cells[2].Value;
            txtSpecijalizacija.Text = (string)dgvLekari.SelectedRows[0].Cells[3].Value;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            VrstaPregleda pregled = new VrstaPregleda()
            {
                Naziv = txtNaziv.Text,
                Oblast = txtOblast.Text,
                Lekar = (Lekar)dgvLekari.SelectedRows[0].DataBoundItem
            };

            Controller.Instance.SacuvajVrstuPregleda(pregled);

            DialogResult result = MessageBox.Show("", "Da li zelite da uneste jos pregleda?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                UserControlHelpers.KreirajUC(new UCUnosPregleda(), this);
            }
            else if (result == DialogResult.No)
            {
                this.Visible = false;
            }
        }

        
    }
}
