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
    public partial class AppendRecordForm : Form
    {
        public AppendRecordForm()
        {
            InitializeComponent();
        }

        private void QuitLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ApplyRecord_button_Click(object sender, EventArgs e)
        {
            dbche addNewItem = new dbche();
            string idconst = "0";
            MySqlCommand addNewRecord = new MySqlCommand("INSERT INTO `items`(`id_item`,`type_item`,`model_name_item`,`discribe_item`,`appending_date`) VALUES (@id_item, @type_item, @model_name_item, @discribe_item, @appending_date)", addNewItem.getConnection());
            addNewRecord.Parameters.Add("@id_item", MySqlDbType.VarChar).Value = idconst;
            addNewRecord.Parameters.Add("@type_item", MySqlDbType.VarChar).Value = itemType_comboBox.Text;
            addNewRecord.Parameters.Add("@model_name_item", MySqlDbType.VarChar).Value = modelNameItem_richTextBox.Text;
            addNewRecord.Parameters.Add("@discribe_item", MySqlDbType.VarChar).Value = discribeItemBad_richTextBox.Text;
            addNewRecord.Parameters.Add("@appending_date", MySqlDbType.VarChar).Value = dateTime_maskedTextBox.Text;
            addNewItem.openConnection();
            if (addNewRecord.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Новая запись успешно добавлена!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Произошла какая-то ошибка, попробуйте снова");
            }

            addNewItem.closeConnection();
        }
    }
}
