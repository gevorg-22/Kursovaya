using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormEditUser : Form
    {
        public FormEditUser()
        {
            InitializeComponent();
        }

        OleDbCommand cmd;
        OleDbConnection connect;
        OleDbDataAdapter adapter;
        DataSet ds;

        private void FormEditUser_Load(object sender, EventArgs e)
        {
            //подключаемся к БД
            connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|users.mdb");
            adapter = new OleDbDataAdapter("SELECT * FROM `user`", connect);
            ds = new DataSet();
            connect.Open();
            adapter.Fill(ds, "user");
            connect.Close();
            textBox1.Text = Properties.Settings.Default.edit_login; //из настроек считываем сохраненный логин юзера
            textBox2.Text = Properties.Settings.Default.edit_fullname; //из настроек считываем созраненное имя юзера
            string type = Properties.Settings.Default.edit_type; //из настроек считываем тип юзера
            //в зависимости от типа юзера выставляем в выпадающем списке нужное значение сразу
            if (type == "Администратор") comboBox1.SelectedIndex = 0;
            else if (type == "Пользователь") comboBox1.SelectedIndex = 1;
            else if (type == "Гость") comboBox1.SelectedIndex = 2;
            else comboBox1.SelectedIndex = -1;
            //считываем булевы значения из настроек и применяем их к чек-кнопкам
            if (Properties.Settings.Default.edit_block) checkBox1.Checked = true;
            if (Properties.Settings.Default.edit_open) checkBox2.Checked = true;
            if (Properties.Settings.Default.edit_closing) checkBox3.Checked = true;
            if (Properties.Settings.Default.edit_shifr) checkBox4.Checked = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // для созранения изменений в данных пользователя, сначала их записываем в настройки, чтобы они были доступны из других форм
            Properties.Settings.Default.edit_fullname = textBox2.Text;
            Properties.Settings.Default.edit_login = textBox1.Text;
            Properties.Settings.Default.edit_type = comboBox1.Text;
            Properties.Settings.Default.edit_block = checkBox1.Checked;
            Properties.Settings.Default.edit_open = checkBox2.Checked;
            Properties.Settings.Default.edit_closing = checkBox3.Checked;
            Properties.Settings.Default.edit_shifr = checkBox4.Checked;
            //составлем SQL запрос на обновление (update) записи в таблице с нужным юзером
            string query = "UPDATE [user] SET [fullname]='" + textBox2.Text + "', [login]='" + textBox1.Text + "', [type]='" +
                comboBox1.Text + "', [block]=" + checkBox1.Checked + ", [open]=" + checkBox2.Checked + ", [closing]=" + checkBox3.Checked +
                ", [shifr_deshifr]=" + checkBox4.Checked + " WHERE [id]=" + Properties.Settings.Default.edit_id;
            cmd = new OleDbCommand(query, connect); //выполняем запрос
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
