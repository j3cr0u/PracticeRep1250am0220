using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DataBase9229
{
    public partial class userLogdeg : Form
    {
        public userLogdeg()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dbche tosee = new dbche();
            String check_item = chooseType_Box.Text;
            DataTable table = new DataTable();
            if (check_item == "Все")
            {
                string selectQueryAll = "SELECT * FROM `items`";
                MySqlDataAdapter myads = new MySqlDataAdapter(selectQueryAll, tosee.getConnection());
                _ = myads.Fill(table);
                dataGridView_Items.DataSource = table;
            }
            else if (check_item == "Мониторы")
            {
                string selectQueryDisplays = "SELECT * FROM `items` WHERE `type_item` = 'Монитор'";
                MySqlDataAdapter myads = new MySqlDataAdapter(selectQueryDisplays, tosee.getConnection());
                myads.Fill(table);
                dataGridView_Items.DataSource = table;
            }
            else if (check_item == "Ноутбуки")
            {
                string selectQueryLaptops = "SELECT * FROM `items` WHERE `type_item`=";
                string wordLaptop = "'Ноутбук'";
                MySqlDataAdapter myads = new MySqlDataAdapter(selectQueryLaptops + wordLaptop, tosee.getConnection());
                myads.Fill(table);
                dataGridView_Items.DataSource = table;
            }
        }

        private void AppendRecord_button_Click(object sender, EventArgs e)
        {
            AppendRecordForm form = new AppendRecordForm();
            form.Show();
        }
    }
}
