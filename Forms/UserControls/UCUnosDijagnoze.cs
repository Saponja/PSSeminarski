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

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            Controller.Instance.SaveMoreDijagnoze(dijagnoze.ToList());
        }
    }
}
