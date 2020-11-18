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
    public partial class UCZakazivanjePregleda : UserControl
    {

        public UCZakazivanjePregleda()
        {
            InitializeComponent();
            dgvPacijent.DataSource = Controller.Instance.PrikaziPacijente();
            dgvPregled.DataSource = Controller.Instance.prikaziPreglede();
            dgvTermini.DataSource = Controller.Instance.PrikaziTermine();
            cbLekar.DataSource = Controller.Instance.PrikaziLekare();
            
        }

        private void btnZakazi_Click(object sender, EventArgs e)
        {
            List<DateTime> termini = Controller.Instance.VratiVremeTermina();
            string datumString = txtDatum.Text + " " + txtVreme.Text;
            DateTime datum = Convert.ToDateTime(datumString);
            if(termini.Any(t => t == datum))
            {
                MessageBox.Show("Termin je vec zauzet");
                txtVreme.BackColor = Color.LightCoral;
                txtDatum.BackColor = Color.LightCoral;
            }
            Termin termin = new Termin()
            {
                Pacijent = (Pacijent)dgvPacijent.SelectedRows[0].DataBoundItem,
                VrstaPregleda = (VrstaPregleda)dgvPregled.SelectedRows[0].DataBoundItem,
                DateTime = datum,
                Cena = 123
            };

            try
            {
                Controller.Instance.SacuvajTermin(termin);
                MessageBox.Show("Uspesno ste zakazali termin");
                dgvTermini.DataSource = Controller.Instance.PrikaziTermine();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void cbLekar_SelectionChangeCommitted(object sender, EventArgs e)
        {

            List<VrstaPregleda> pregledi = Controller.Instance.prikaziPreglede();
            List<Pacijent> pacijenti = Controller.Instance.PrikaziPacijente();

            Lekar lekar = (Lekar)cbLekar.SelectedItem;
            pregledi = pregledi.Where(p => p.Lekar.LekarID == lekar.LekarID).ToList();
            pacijenti = pacijenti.Where(p => p.Bolnica.SifraBolnice == lekar.Bolnica.SifraBolnice).ToList();
            dgvPregled.DataSource = pregledi;
            dgvPacijent.DataSource = pacijenti;
            
        }
    }
}
