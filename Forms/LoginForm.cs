using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp90.Services;

namespace WinFormsApp90.Forms
{
    public partial class LoginForm : Form
    {
        private LoginService _loginService;
        public LoginForm ()
        {
            InitializeComponent();
            _loginService = new LoginService ();
        }

        private void LoginForm_Load (object sender, EventArgs e)
        {
        }

        private void button1_Click (object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxLogin.Text) ||
                      !string.IsNullOrEmpty(textBoxHaslo.Text))
            {
                if (_loginService.Zaloguj(textBoxLogin.Text, textBoxHaslo.Text))
                {
                    Visible = false;

                    Form1 f = new Form1 ();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Błędny login lub hasło");
                    textBoxLogin.Text = "";
                    textBoxHaslo.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Wprowadź dane do logowania");
            }
        }


        private void button2_Click (object sender, EventArgs e)
        {
            Close ();
        }

    }
}
