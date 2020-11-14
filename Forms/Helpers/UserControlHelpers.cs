using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.Helpers
{
    public class UserControlHelpers
    {
        public static bool EmptyFieldValidation(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.BackColor = Color.LightCoral;
                return true;
            }
            else
            {
                txt.BackColor = Color.White;
                return false;
            }
        }

        public static void KreirajUC(UserControl userControl, UserControl thisUC)
        {
            thisUC.Controls.Clear();
            userControl.Parent = thisUC;
            userControl.Dock = DockStyle.Fill;
        }
    }
}
