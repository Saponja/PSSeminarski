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
using ControllerB;
using Forms.Helpers;
using System.Globalization;

namespace Forms.UserControls
{
    public partial class ZakazivanjeTermina : UserControl
    {
        private BindingList<Termin> termini = new BindingList<Termin>(Communication.Communication.Instance.PrikaziTermine());
        private BindingList<Termin> listaTermina = new BindingList<Termin>();
        private bool isset = false;

        public ZakazivanjeTermina()
        {
            InitializeComponent();
            cbLekari.DataSource = Communication.Communication.Instance.PrikaziLekare();
            List<Pacijent> pacijenti = Communication.Communication.Instance.PrikaziPacijente();
            List<VrstaPregleda> pregledi = Communication.Communication.Instance.PrikaziPreglede();
            dgvTermini.DataSource = listaTermina;
            //ChangeDataGridView();


        }

        private void ChangeDataGridView()
        {
            List<VrstaPregleda> pregledi = Communication.Communication.Instance.PrikaziPreglede();
            List<Pacijent> pacijenti = Communication.Communication.Instance.PrikaziPacijente();

            Lekar lekar = (Lekar)cbLekari.SelectedItem;
            pregledi = pregledi.Where(p => p.Lekar.LekarID == lekar.LekarID).ToList();
            pacijenti = pacijenti.Where(p => p.Bolnica.SifraBolnice == lekar.Bolnica.SifraBolnice).ToList();

            dgvTermini.DataSource = listaTermina;
            AddComboBoxPacijenti(dgvTermini, pacijenti);
            AddComboBoxPregledi(dgvTermini, pregledi);


        }

        private void InitDataGridView(DataGridView dgvTermini, List<Pacijent> pacijenti, List<VrstaPregleda> pregledi)
        {
            AddComboBoxPacijenti(dgvTermini, pacijenti);
            AddComboBoxPregledi(dgvTermini, pregledi);
        }

        private void AddComboBoxPacijenti(DataGridView dgvTermini, List<Pacijent> pacijenti)
        {
            dgvTermini.Columns["Pacijent"].Visible = false;
            DataGridViewComboBoxColumn columnPacijent =
                new DataGridViewComboBoxColumn();
            columnPacijent.DataPropertyName = "Pacijent";
            columnPacijent.DataSource = pacijenti;

            columnPacijent.DisplayMember = "Ime";
            columnPacijent.ValueMember = "Self";

            columnPacijent.HeaderText = "Pacijent";

            dgvTermini.Columns.Add(columnPacijent);
            
        }

        private void AddComboBoxPregledi(DataGridView dgvTermini, List<VrstaPregleda> pregledi)
        {
            dgvTermini.Columns["VrstaPregleda"].Visible = false;
            DataGridViewComboBoxColumn columnPregled =
                new DataGridViewComboBoxColumn();
            columnPregled.DataPropertyName = "VrstaPregleda";
            columnPregled.DataSource = pregledi;

            columnPregled.DisplayMember = "Naziv";
            columnPregled.ValueMember = "Self";


            columnPregled.HeaderText = "VrstaPregleda";
            dgvTermini.Columns.Add(columnPregled);

        }

        private void cbLekari_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbLekari.Enabled = false;
            ChangeDataGridView();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            //Provera da li je termin zauzet za tog lekara

            if (!UserControlHelpers.EmptyFieldValidation(txtDate) && DateTime.TryParseExact(txtDate.Text, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                if (SlobodanTerminLekara((Lekar)cbLekari.SelectedItem, date))
                {
                listaTermina.Add(new Termin
                {
                    DateTime = DateTime.ParseExact(txtDate.Text, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture)
                });
                }
            }
            else
            {
                MessageBox.Show("Unesite datum u formatu dd.MM.yyyy HH:mm");
            }
        }

        private void btnZakazi_Click(object sender, EventArgs e)
        {
            List<Termin> termini = new List<Termin>();
            foreach (DataGridViewRow row in dgvTermini.Rows)
            {
                termini.Add((Termin)row.DataBoundItem);
            }
            

            Communication.Communication.Instance.SacuvajTermine(termini);

            

            UserControlHelpers.KreirajUC(new ZakazivanjeTermina(), this);
        }

        private bool SlobodanTerminLekara(Lekar lekar, DateTime date)
        {
            if(date < DateTime.Now)
            {
                MessageBox.Show("Datum je prosao!");
                txtDate.BackColor = Color.LightCoral;
                return false;
            }

            if(date.Hour < 8 || date.Hour > 16)
            {
                MessageBox.Show("Radno vreme klinike je od 08:00 do 16:00!");
                txtDate.BackColor = Color.LightCoral;
                return false;
            }

            foreach (DateTime d in Controller.Instance.VratiVremeTermina(lekar))
            {
                if (date.Equals(d))
                {
                    MessageBox.Show("Termin je zauzet pokusajte sa novim!");
                    txtDate.BackColor = Color.LightCoral;
                    txtDate.Text = date.AddHours(1).ToString("dd.MM.yyyy HH:mm");
                    return false;
                }
            }

            txtDate.BackColor = Color.White;
            return true;


        }
    }
}
