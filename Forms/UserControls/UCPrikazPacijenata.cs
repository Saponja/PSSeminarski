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

namespace Forms.UserControls
{
    public partial class UCPrikazPacijenata : UserControl
    {
        public UCPrikazPacijenata()
        {
            InitializeComponent();
            dgvPacijenti.DataSource = Controller.Instance.PrikaziPacijente();
        }



    }
}
