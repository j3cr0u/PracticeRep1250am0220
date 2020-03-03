using MySql.Data.MySqlClient;
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
            if (loginTextbox.Text == "Enter your Login")
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
            if (userCheck())
            {
                return;
            }
            dbche userRegEx = new dbche();
            MySqlCommand RegisterUserCommand = new MySqlCommand("INSERT INTO`users`(`Login`,`Password`,`Email`,`Name`) VALUES (@Login, @Password, @Email, @Name)", userRegEx.getConnection());
            RegisterUserCommand.Parameters.Add("@Login", MySqlDbType.VarChar).Value = loginTextbox.Text;
            RegisterUserCommand.Parameters.Add("@Password", MySqlDbType.VarChar).Value = passwordTextbox.Text;
            RegisterUserCommand.Parameters.Add("@Email", MySqlDbType.VarChar).Value = emailTextbox.Text;
            RegisterUserCommand.Parameters.Add("@Name", MySqlDbType.VarChar).Value = nameTextbox.Text;
            userRegEx.openConnection();
            if (RegisterUserCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Регистрация прошла успешно");
                this.Close();
                loginForm window = new loginForm();
                window.Show();
            }
            else
                MessageBox.Show("Регистрация не прошла");

            userRegEx.closeConnection();
        }

        public Boolean userCheck()
        {
            dbche userCheckEx = new dbche();
            DataTable maintable = new DataTable();
            MySqlDataAdapter tableAdapter = new MySqlDataAdapter();
            MySqlCommand ChooseLogColumn = new MySqlCommand("SELECT * FROM `maintable` WHERE `Login`=@Lg", userCheckEx.getConnection());
            ChooseLogColumn.Parameters.Add("@Lg", MySqlDbType.VarChar).Value = loginTextbox.Text;
            tableAdapter.SelectCommand = ChooseLogColumn;
            tableAdapter.Fill(maintable);
            if (maintable.Rows.Count > 0)
            {
                MessageBox.Show("Login already exists(пошёл нахуй)");
                return true;
            }
            else
            {
                return false;
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
