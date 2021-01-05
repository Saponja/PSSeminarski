using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Storage;
using Storage.Implementation;
using Domain;
using ControllerB;
using Forms.Helpers;

namespace Forms.UserControls
{
    public partial class UCUnosPacijenta : UserControl
    {
        private IStorageBolnice storageBolnice;

        public UCUnosPacijenta()
        {
            InitializeComponent();
            storageBolnice = new StorageBolnice();
            List<Bolnica> bolnice = storageBolnice.GetAll();
            cbBolnica.DataSource = bolnice;  
            
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            bool hitan = true;
            if(rbHitanNe.Checked == true)
            {
                hitan = false;
            }
            Pacijent pacijent = new Pacijent()
            {
                Ime = (string)txtIme.Text,
                Prezime = (string)txtPrezime.Text,
                DaumRodjenja = (DateTime)dtpDatum.Value,
                Hitan = hitan,
                Anamneza = (string)rtbAnamneza.Text,
                Bolnica = (Bolnica)cbBolnica.SelectedItem
            };

            try
            {
                Communication.Communication.Instance.SacuvajPacijenta(pacijent);
                MessageBox.Show("Pacijent je uspesno sacuvan!");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            DialogResult result = MessageBox.Show("", "Da li zelite da uneste jos pacijenata?", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                UserControlHelpers.KreirajUC(new UCUnosPacijenta(), this);
            }
            else if(result == DialogResult.No)
            {
                this.Visible = false;
            }
            

        }

    }
}
