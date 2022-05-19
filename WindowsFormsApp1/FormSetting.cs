using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
        }

        string GetHashString(string s)
        {
            //переводим строку в байт-массим  
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            //создаем объект для получения средст шифрования  
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            //вычисляем хеш-представление в байтах  
            byte[] byteHash = CSP.ComputeHash(bytes);
            string hash = string.Empty;
            //формируем одну цельную строку из массива  
            foreach (byte b in byteHash) hash += string.Format("{0:x2}", b);
            return hash;
        }

        OleDbCommand cmd;
        OleDbConnection connect;
        OleDbDataAdapter adapter;
        DataSet ds;

        private void FormSetting_Load(object sender, EventArgs e)
        {
            string type = Properties.Settings.Default.type;
            if (type == "Пользователь") //если мы пользователь, то показываем ограниченные настройки юзера
            {
                pUser.Visible = true;
                pAdmin.Visible = false;
                this.Text = "Настройки пользователя";
                this.Width = 320;
                this.Height = 290;
            }
            else //иначе если мы админ, то настройки показываем расширенные
            {
                pUser.Visible = false;
                pAdmin.Visible = true;
                this.Text = "Панель администратора";
                this.Width = 1090;
                this.Height = 500;
                label2.Text = "Пользователь: " + Properties.Settings.Default.fullname + ", Тип: " + Properties.Settings.Default.type +
                    ", ID: " + Properties.Settings.Default.id;
            }
            connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|users.mdb");
            adapter = new OleDbDataAdapter("SELECT * FROM `user`", connect);
            ds = new DataSet();
            connect.Open();
            adapter.Fill(ds, "user");
            dataGridView1.DataSource = ds.Tables["user"];
            connect.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUser au = new AddUser();
            label1.Text = Convert.ToString(Properties.Settings.Default.counter);
            au.Show();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int index;
            if (Properties.Settings.Default.login.Length > 0)
            {
                index = Properties.Settings.Default.counter + 1;
                string hash = GetHashString(Properties.Settings.Default.password);
                object[] dataRow = new object[9] { index, Properties.Settings.Default.login, hash,
                Properties.Settings.Default.fullname, Properties.Settings.Default.type, false, Properties.Settings.Default.open,
                Properties.Settings.Default.save, Properties.Settings.Default.shifr};
                ds.Tables["user"].Rows.Add(dataRow);
                string query = "INSERT INTO [user] ([id], [login], [password], [fullname], [type], [block], [open], [closing], [shifr_deshifr]) VALUES (";
                query += Convert.ToString(index) + ", '" + Properties.Settings.Default.login + "', '" +
                    hash + "', '" + Properties.Settings.Default.fullname + "', '" +
                    Properties.Settings.Default.type + "', False, " + Properties.Settings.Default.open + ", " +
                    Properties.Settings.Default.save + ", " + Properties.Settings.Default.shifr + ")";
                label1.Text = query;
                cmd = new OleDbCommand(query, connect);
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
                Properties.Settings.Default.login = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.fullname = "";
                Properties.Settings.Default.type = "";
                Properties.Settings.Default.open = false;
                Properties.Settings.Default.save = false;
                Properties.Settings.Default.shifr = false;
                Properties.Settings.Default.counter = index;
                Properties.Settings.Default.Save();
                timer1.Stop();
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|users.mdb");
            adapter = new OleDbDataAdapter("SELECT * FROM `user`", connect);
            ds = new DataSet();
            connect.Open();
            adapter.Fill(ds, "user");
            dataGridView1.DataSource = ds.Tables["user"];
            connect.Close();
            dataGridView1.Refresh();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            int current_row = dataGridView1.CurrentRow.Index;
            string current_index = dataGridView1.Rows[current_row].Cells[0].Value.ToString();
            string query = "DELETE FROM [user] WHERE [id]=" + current_index;
            cmd = new OleDbCommand(query, connect);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Пользователь удален!");
            adapter = new OleDbDataAdapter("SELECT * FROM `user`", connect);
            ds = new DataSet();
            connect.Open();
            adapter.Fill(ds, "user");
            dataGridView1.DataSource = ds.Tables["user"];
            connect.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = "Выделена строка #" + Convert.ToString(dataGridView1.CurrentCell.RowIndex);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = "Выделена строка #" + Convert.ToString(dataGridView1.CurrentCell.RowIndex);
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            int current_row = dataGridView1.CurrentCell.RowIndex;
            Properties.Settings.Default.edit_row = current_row;
            Properties.Settings.Default.edit_fullname = dataGridView1.Rows[current_row].Cells[3].Value.ToString();
            Properties.Settings.Default.edit_id = Convert.ToInt32(dataGridView1.Rows[current_row].Cells[0].Value.ToString());
            Properties.Settings.Default.edit_login = dataGridView1.Rows[current_row].Cells[1].Value.ToString();
            Properties.Settings.Default.edit_type = dataGridView1.Rows[current_row].Cells[4].Value.ToString();
            Properties.Settings.Default.edit_block = Convert.ToBoolean(dataGridView1.Rows[current_row].Cells[5].Value.ToString());
            Properties.Settings.Default.edit_open = Convert.ToBoolean(dataGridView1.Rows[current_row].Cells[6].Value.ToString());
            Properties.Settings.Default.edit_closing = Convert.ToBoolean(dataGridView1.Rows[current_row].Cells[7].Value.ToString());
            Properties.Settings.Default.edit_shifr = Convert.ToBoolean(dataGridView1.Rows[current_row].Cells[8].Value.ToString());
            FormEditUser feu = new FormEditUser();
            feu.Show();
        }

        private void bPassword_Click(object sender, EventArgs e)
        {
            int current_row = dataGridView1.CurrentCell.RowIndex;
            Properties.Settings.Default.edit_id = Convert.ToInt32(dataGridView1.Rows[current_row].Cells[0].Value.ToString());
            FormEditPassword fep = new FormEditPassword();
            fep.Show();
        }
    }
}
