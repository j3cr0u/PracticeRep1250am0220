using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase9229
{
    public partial class userReg : Form
    {
        public userReg()
        {
            InitializeComponent();
            loginTextbox.Text = "Enter your Login";
            passwordTextbox.Text = "Your password";
            nameTextbox.Text = "Your name";
            emailTextbox.Text = "Your E-mail";
            loginTextbox.ForeColor = Color.Gray;
            passwordTextbox.ForeColor = Color.Gray;
            nameTextbox.ForeColor = Color.Gray;
            emailTextbox.ForeColor = Color.Gray;
        }

        private void loginTextbox_Enter(object sender, EventArgs e)
        {
            if(loginTextbox.Text== "Enter your Login")
            {
                loginTextbox.Text = "";
                loginTextbox.ForeColor = Color.Black;
            }
        }

        private void loginTextbox_Leave(object sender, EventArgs e)
        {
            if (loginTextbox.Text == "")
            {
                loginTextbox.Text = "Enter your Login";
                loginTextbox.ForeColor = Color.Gray;
            }
        }

        private void passwordTextbox_Enter(object sender, EventArgs e)
        {
            if (passwordTextbox.Text == "Your password")
            {
                passwordTextbox.Text = "";
                passwordTextbox.ForeColor = Color.Black;
            }
        }

        private void passwordTextbox_Leave(object sender, EventArgs e)
        {
            if (passwordTextbox.Text == "")
            {
                passwordTextbox.Text = "Your password";
                passwordTextbox.ForeColor = Color.Gray;
            }
        }

        private void nameTextbox_Enter(object sender, EventArgs e)
        {
            if (nameTextbox.Text == "Your name")
            {
                nameTextbox.Text = "";
                nameTextbox.ForeColor = Color.Black;
            }
        }

        private void nameTextbox_Leave(object sender, EventArgs e)
        {
            if (nameTextbox.Text == "")
            {
                nameTextbox.Text = "Your name";
                nameTextbox.ForeColor = Color.Gray;
            }
        }

        private void emailTextbox_Enter(object sender, EventArgs e)
        {
            if (emailTextbox.Text == "Your E-mail")
            {
                emailTextbox.Text = "";
                emailTextbox.ForeColor = Color.Black;
            }
        }

        private void emailTextbox_Leave(object sender, EventArgs e)
        {
            if (emailTextbox.Text == "")
            {
                emailTextbox.Text = "Your E-mail";
                emailTextbox.ForeColor = Color.Gray;
            }
        }

        private void userReg_Load(object sender, EventArgs e)
        {
            registerButton.Select();
            registerButton.Focus();
        }

        private void quitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (loginTextbox.Text == "Enter your login" || passwordTextbox.Text == "Your password" || nameTextbox.Text == "Your name" || emailTextbox.Text == "Your E-mail") //проверка на ввод данных в полне имя
            {
                MessageBox.Show("Some blocks left unfilled");
                return;
            }
        }

        private void alreadyHaveAccLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm forma = new loginForm();
            forma.Show();
        }
    }
}
