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
        private BindingList<Termin> termini = new BindingList<Termin>(Controller.Instance.PrikaziTermine());
        public UCZakazivanjePregleda()
        {
            InitializeComponent();
            dgvPacijent.DataSource = Controller.Instance.PrikaziPacijente();
            dgvPregled.DataSource = Controller.Instance.prikaziPreglede();
            dgvTermini.DataSource = termini;
            cbLekar.DataSource = Controller.Instance.PrikaziLekare();
            
        }

        //Prvo dodaj sve u dgv, a onda kad se klikne zakazi, tada ih sacuvaj sve odjednom!!!

        private void btnZakazi_Click(object sender, EventArgs e)
        {
            if(dgvPacijent.SelectedRows.Count < 0 || dgvPregled.SelectedRows.Count < 0)
            {
                MessageBox.Show("Morate da izaberete pacijenta i pregled iz tabela");
                return;
            }

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

        private void UCZakazivanjePregleda_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string datumString = txtDatum.Text + " " + txtVreme.Text;
            DateTime datum = Convert.ToDateTime(datumString);
            Termin termin = new Termin()
            {
                Pacijent = (Pacijent)dgvPacijent.SelectedRows[0].DataBoundItem,
                VrstaPregleda = (VrstaPregleda)dgvPregled.SelectedRows[0].DataBoundItem,
                DateTime = datum,
                Cena = 123
            };

            termini.Add(termin);


        }
    }
}
