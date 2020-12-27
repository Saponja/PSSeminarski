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

namespace Forms.UserControls
{
    public partial class UCKarton : UserControl
    {
        List<Dijagnoza> dijagnoze = new List<Dijagnoza>();
        public UCKarton(Pacijent pacijent)
        {
            InitializeComponent();
            Pacijent pacijentKarton = pacijent;
            dijagnoze = Controller.Instance.GetDijagnoze();
            lblPacijent.Text = pacijent.Ime + " " + pacijent.Prezime;
            lblTermin.Text = Controller.Instance.SledeciTermin(pacijent.PacijentID).ToString();

            dgvDijagnoze.DataSource = dijagnoze.Where(d => d.PacijentId == pacijentKarton.PacijentID).ToList();
            
        }

      
    }
}
