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

            Controller.Instance.SacuvajPacijenta(pacijent);

  
        }
    }
}
