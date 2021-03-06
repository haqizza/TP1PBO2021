using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1PBO2021
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public bool UserSuccessfullyAuthenticated { get; private set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbPassword.Text == "pbo123")
            {
                UserSuccessfullyAuthenticated = true;
                this.Hide();
                
                var mainMenu = new MainMenu();
                mainMenu.ShowDialog();

                this.Show();
            }
            else
            {   
                string message = "Password Anda salah";
                string title = "Warning";
                MessageBox.Show(message, title);
            }
        }

    }
}
