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
    public partial class eraiseRecordForm : Form
    {
        public eraiseRecordForm()
        {
            InitializeComponent();
        }

        private void QuitLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EraiseRecord_button_Click(object sender, EventArgs e)
        {
            /* MySqlDataAdapter msda = new MySqlDataAdapter();
            MySqlCommand removeIdRecord = new MySqlCommand();
            MySqlParameter msp = new MySqlParameter();
            dbche tempo = new dbche();
            string deleleCond = idToDelete_textBox.Text;
            removeIdRecord = new MySqlCommand("SELECT * FROM `items` WHERE `id_item`= " + deleleCond, tempo.getConnection());
            removeIdRecord.Parameters.Add("@id", MySqlDbType.VarChar);
            msda.SelectCommand = removeIdRecord;
            removeIdRecord = new MySqlCommand("DELETE FROM `items` WHERE `id_item`= " + deleleCond, tempo.getConnection());
            msp = removeIdRecord.Parameters.Add("@id", MySqlDbType.VarChar, 5, deleleCond);
            msp.SourceVersion = DataRowVersion.Original;
            msda.DeleteCommand = removeIdRecord; */

            dbche tempo = new dbche();
            string deleleCond = idToDelete_textBox.Text;
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `items` WHERE `id_item`=@id", tempo.getConnection());
            MySqlParameter param = new MySqlParameter("@id", deleleCond);
            cmd.Parameters.Add(param);
            tempo.openConnection();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Запись успешно удалена");
            userLogdeg form = new userLogdeg();
            form.proceedFilter_Button.PerformClick();
            this.Close();

        }
    }
}
