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

        MainController main = new MainController();
        public FormLogin()
        {
            InitializeComponent();
            txtUsername.Text = "Jovan";
            txtPassword.Text = "Jovan";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            main.Connect();

            if (UserControlHelpers.EmptyFieldValidation(txtUsername) | UserControlHelpers.EmptyFieldValidation(txtPassword))
            {
                return;
            }

           
            Korisnik korisnik = Communication.Communication.Instance.Login(txtUsername.Text, txtPassword.Text);
            if(korisnik != null)
            {
                if(korisnik.KorisnikId != -1)
                {
                    MessageBox.Show("Uspesno ste se ulogovali");
                    FormMain frmMain = new FormMain();
                    this.Visible = false;
                    frmMain.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("Korisnik sa datim usernamom je vec prijavljen");
                }
                
            }
            else
            {
                MessageBox.Show("Korisnik sa datim username-om i password-om ne postoji!");
                return;
            }

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

            //main.Connect();
        }
    }
}
