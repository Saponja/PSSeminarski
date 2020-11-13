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
    public partial class UCUnosPregleda : UserControl
    {
        public UCUnosPregleda()
        {
            InitializeComponent();
            dgvLekari.DataSource = Controller.Instance.PrikaziLekare();
            
        }

    }
}
