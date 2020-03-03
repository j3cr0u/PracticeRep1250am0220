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
    public partial class loginForm : Form
    {

        public loginForm()
        {
            InitializeComponent();
        }

        private void quitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String userLogin = usernameTextbox.Text;
            String userPass = passTextbox.Text;
            dbche example1 = new dbche();
            DataTable mtbtable = new DataTable();
            MySqlDataAdapter msdadapter = new MySqlDataAdapter();
            MySqlCommand retriveDataCmd = new MySqlCommand("SELECT * FROM `users` WHERE `Login`=@log AND `Password`=@pass", example1.getConnection());
            retriveDataCmd.Parameters.Add("@log", MySqlDbType.VarChar).Value = userLogin;
            retriveDataCmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = userPass;
            msdadapter.SelectCommand = retriveDataCmd;
            msdadapter.Fill(mtbtable);
            if (mtbtable.Rows.Count > 0)
            {
                this.Hide();
                userLogdeg forma = new userLogdeg();
                forma.Show();
            }
            else
            {
                MessageBox.Show("Вы не зарегистрированы");
            }
        }

        private void suggestRegistrationLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            userReg forma = new userReg();
            forma.Show();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            loginButton.Select();
            loginButton.Focus();
        }
    }
}
