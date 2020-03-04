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
            string selectFromItems = "SELECT * FROM `items` ";
            string whereCondition = "WHERE `type_item` = ";
            if (check_item == "Все")
            {
                MySqlDataAdapter myads = new MySqlDataAdapter(selectFromItems, tosee.getConnection());
                _ = myads.Fill(table);
                dataGridView_Items.DataSource = table;
            }
            else if (check_item == "Мониторы")
            {
                MySqlDataAdapter myads = new MySqlDataAdapter(selectFromItems + whereCondition +"'Монитор'", tosee.getConnection());
                myads.Fill(table);
                dataGridView_Items.DataSource = table;
            }
            else if (check_item == "Ноутбуки")
            {
                MySqlDataAdapter myads = new MySqlDataAdapter(selectFromItems + whereCondition + "'Ноутбук'", tosee.getConnection());
                myads.Fill(table);
                dataGridView_Items.DataSource = table;
            }
            else if (check_item == "Компьютеры")
            {
                MySqlDataAdapter myads = new MySqlDataAdapter(selectFromItems + whereCondition + "'Компьютер'", tosee.getConnection());
                myads.Fill(table);
                dataGridView_Items.DataSource = table;
            }
            else if (check_item == "Видеокарты")
            {
                MySqlDataAdapter myads = new MySqlDataAdapter(selectFromItems + whereCondition + "'Видеокарта'", tosee.getConnection());
                myads.Fill(table);
                dataGridView_Items.DataSource = table;
            }
            else if (check_item == "Планшеты")
            {
                MySqlDataAdapter myads = new MySqlDataAdapter(selectFromItems + whereCondition + "'Планшет'", tosee.getConnection());
                myads.Fill(table);
                dataGridView_Items.DataSource = table;
            }
            else if (check_item == "Телефоны")
            {
                MySqlDataAdapter myads = new MySqlDataAdapter(selectFromItems + whereCondition + "'Телефон'", tosee.getConnection());
                myads.Fill(table);
                dataGridView_Items.DataSource = table;
            }
            else if (check_item == "Телевизоры")
            {
                MySqlDataAdapter myads = new MySqlDataAdapter(selectFromItems + whereCondition + "'Телевизор'", tosee.getConnection());
                myads.Fill(table);
                dataGridView_Items.DataSource = table;
            }
            else if (check_item == "Передатчики")
            {
                MySqlDataAdapter myads = new MySqlDataAdapter(selectFromItems + whereCondition + "'Передатчик'", tosee.getConnection());
                myads.Fill(table);
                dataGridView_Items.DataSource = table;
            }
            else if (check_item == "Другое")
            {
                MySqlDataAdapter myads = new MySqlDataAdapter(selectFromItems + whereCondition + "'Другое'", tosee.getConnection());
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
