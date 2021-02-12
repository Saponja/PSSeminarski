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
            dgvLekari.DataSource = Communication.Communication.Instance.PrikaziLekare();
            
        }

        private void dgvLekari_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIme.Text = (string)dgvLekari.SelectedRows[0].Cells[1].Value;
            txtPrezime.Text = (string)dgvLekari.SelectedRows[0].Cells[2].Value;
            txtSpecijalizacija.Text = (string)dgvLekari.SelectedRows[0].Cells[3].Value;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(!UserControlHelpers.EmptyFieldValidation(txtNaziv) & !UserControlHelpers.EmptyFieldValidation(txtOblast) 
                && dgvLekari.SelectedRows.Count == 1)
            {
                if (!UserControlHelpers.HasNumberOrSymbol(txtIme) && !UserControlHelpers.HasNumberOrSymbol(txtPrezime))
                {
                    VrstaPregleda pregled = new VrstaPregleda()
                    {
                        Naziv = txtNaziv.Text,
                        Oblast = txtOblast.Text,
                        Lekar = (Lekar)dgvLekari.SelectedRows[0].DataBoundItem
                    };

                    if (Communication.Communication.Instance.SacuvajVrstuPregleda(pregled))
                    {
                        MessageBox.Show("Novi pregled je uspesno sacuvan");
                    }
                    else
                    {
                        MessageBox.Show("Dati tip pregleda vec postoji");
                    }

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
                else
                {
                    MessageBox.Show("Naziv i oblast ne smeju da sadrze cifre");
                }

                
            }
            else
            {
                MessageBox.Show("Popunite sva polja i izaberite jednog lekara!");
            }
            
        }

        
    }
}
