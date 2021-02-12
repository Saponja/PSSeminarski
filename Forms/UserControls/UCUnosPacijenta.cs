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

        public UCUnosPacijenta()
        {
            InitializeComponent();
            List<Bolnica> bolnice = Communication.Communication.Instance.PrikaziBolnice();
            cbBolnica.DataSource = bolnice;
            cbBolnica.SelectedIndex = -1;
            
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {

            if(!UserControlHelpers.EmptyFieldValidation(txtIme) & !UserControlHelpers.EmptyFieldValidation(txtPrezime)
                & cbBolnica.SelectedIndex != -1)
            {
                if (!UserControlHelpers.HasNumberOrSymbol(txtIme) && !UserControlHelpers.HasNumberOrSymbol(txtPrezime))
                {
                    bool hitan = true;
                    if (rbHitanNe.Checked == true)
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

                    if (Communication.Communication.Instance.SacuvajPacijenta(pacijent))
                    {
                        MessageBox.Show("Pacijent je uspesno sacuvan!");
                    }
                    else
                    {
                        MessageBox.Show("Pacijent vec postoji u bazi!");
                    }



                    DialogResult result = MessageBox.Show("", "Da li zelite da uneste jos pacijenata?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        UserControlHelpers.KreirajUC(new UCUnosPacijenta(), this);
                    }
                    else if (result == DialogResult.No)
                    {
                        this.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Ime i prezime ne smeju da sadrze cifre");
                }
               
            }
            else
            {
                MessageBox.Show("Unesite sva potrebna polja");
            }


            
            

        }

    }
}
