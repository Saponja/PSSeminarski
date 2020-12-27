using ControllerB;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.Dialogs
{
    public partial class UnosDijagnozeDialogs : Form
    {
        public UnosDijagnozeDialogs()
        {
            InitializeComponent();
            cbPacijent.DataSource = Controller.Instance.PrikaziPacijente();
            cbTip.DataSource = Controller.Instance.GetTip();
            cbTip.DisplayMember = "Naziv";
            cbTip.SelectedIndex = -1;
            cbPacijent.SelectedIndex = -1;

        }

        public Pacijent Pacijent { get; set; }
        public TipDijagnoze Tip { get; set; }
        public DateTime Datum { get; set; }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(cbPacijent.SelectedIndex != -1 && cbTip.SelectedIndex != -1 &&
                DateTime.TryParseExact(txtDatum.Text, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture,
                DateTimeStyles.None, out DateTime date))
            {
                Pacijent = (Pacijent)cbPacijent.SelectedItem;
                Tip = (TipDijagnoze)cbTip.SelectedItem;
                Datum = date;

                this.Dispose();

            }
            else
            {
                MessageBox.Show("Podaci nisu dobro uneti");
            }
            
        }
    }
}
