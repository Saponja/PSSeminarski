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

namespace Forms.UserControls
{
    public partial class UCPrikazTermina : UserControl
    {
        List<Termin> termini = new List<Termin>();
        public UCPrikazTermina()
        {
            InitializeComponent();
            termini = Communication.Communication.Instance.PrikaziTermine();
            cbLekari.DataSource = Communication.Communication.Instance.PrikaziLekare();
            dgvTermini.DataSource = termini;
        }

        private void cbLekari_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Lekar lekar = (Lekar)cbLekari.SelectedItem;
            termini = termini.Where(t => t.VrstaPregleda.Lekar.LekarID == lekar.LekarID).ToList();
            dgvTermini.DataSource = termini;
            termini = Communication.Communication.Instance.PrikaziTermine();
        }
    }
}
