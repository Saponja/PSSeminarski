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
using Forms.Dialogs;
using ControllerB;

namespace Forms.UserControls
{
    public partial class UCUnosDijagnoze : UserControl
    {
        BindingList<Dijagnoza> dijagnoze = new BindingList<Dijagnoza>();
        public UCUnosDijagnoze()
        {
            InitializeComponent();
            dgvDijagnoze.DataSource = dijagnoze;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            UnosDijagnozeDialogs dialog = new UnosDijagnozeDialogs();
            dialog.ShowDialog();
            if(dialog.Pacijent != null && dialog.Tip != null && dialog.Datum != null)
            {
                Dijagnoza dijagnoza = new Dijagnoza
                {
                    Datum = dialog.Datum,
                    Pacijent = dialog.Pacijent,
                    TipDijagnoze = dialog.Tip,
                    PacijentId = dialog.Pacijent.PacijentID,
                    DijagnozaId = dialog.Tip.DijagnozaID
                };
                dijagnoze.Add(dijagnoza);
                dgvDijagnoze.DataSource = dijagnoze;

            }
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if(dijagnoze.Count > 0)
            {
                if (Communication.Communication.Instance.SacuvajDijagnozu(dijagnoze.ToList()))
                {
                    MessageBox.Show("Uspesno ste uneli dijagnoze");
                }
                else
                {
                    MessageBox.Show("Neka od dijagnoza je vec postavljena");
                }
                
            }
            else
            {
                MessageBox.Show("Morate uneti neku dijagnozu");
            }
           
        }
    }
}
