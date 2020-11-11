using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControllerB;
using Domain;
using Forms.Helpers;
using Storage;
using Storage.Implementation;


namespace Forms
{
    public partial class FormLogin : Form
    {
        //private Controller kontroler;

        public FormLogin()
        {
            InitializeComponent();
            //kontroler = new Controller();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (UserControlHelpers.EmptyFieldValidation(txtUsername) | UserControlHelpers.EmptyFieldValidation(txtPassword))
            {
                return;
            }

            try
            {
                Korisnik korisnik =Controller.Instance.Prijava(txtUsername.Text, txtPassword.Text);
                MessageBox.Show($"Dobrodosli, {Controller.Instance.LoggedInKorisnik.Username}");
                FormMain frmMain = new FormMain();
                this.Visible = false;
                frmMain.ShowDialog();
                this.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }


            

        }
    }
}
