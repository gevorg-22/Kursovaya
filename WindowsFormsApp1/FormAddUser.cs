using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormEditPassword : Form
    {
        public FormEditPassword()
        {
            InitializeComponent();
        }

        OleDbCommand cmd;
        OleDbConnection connect;
        OleDbDataAdapter adapter;
        DataSet ds;

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

        private void button1_Click(object sender, EventArgs e)
        {
            string hash = GetHashString(textBox2.Text);
            string query = "UPDATE [user] SET [password]='" + hash + "' WHERE [id]=" + Properties.Settings.Default.edit_id;
            cmd = new OleDbCommand(query, connect);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
            this.Close();
        }

        private void FormEditPassword_Load(object sender, EventArgs e)
        {
            connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|users.mdb");
            adapter = new OleDbDataAdapter("SELECT * FROM `user`", connect);
            ds = new DataSet();
            connect.Open();
            adapter.Fill(ds, "user");
            connect.Close();
        }
    }
}
