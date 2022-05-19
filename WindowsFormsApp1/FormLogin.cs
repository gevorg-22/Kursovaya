using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
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
        int counterblock = 0;
        private void button1_Click(object sender, EventArgs e) //кнопка "Войти"
        {
            string login = tBLogin.Text;
            bool check = false;
            bool block = false;
            int currentrow = 0;

                for (int i = 0; i < dataGridView1.RowCount - 1; i++) //ищем юзера среди зарегистрированных
                {
                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == login) //если нашли юзера по логину в таблице, то...
                {
                    check = true; //ставим признак того, что юзер есть и он зареган
                    currentrow = i; //запоминаем в какой строке найден юзер...
                    Properties.Settings.Default.id = Convert.ToInt32(dataGridView1.Rows[currentrow].Cells[0].Value.ToString()); //пишем в настройки id юзера
                    Properties.Settings.Default.fullname = dataGridView1.Rows[currentrow].Cells[3].Value.ToString(); //пишем в настройки имя юзера
                    Properties.Settings.Default.type = dataGridView1.Rows[currentrow].Cells[4].Value.ToString(); //пишем в настройки тип юзера
                    Properties.Settings.Default.open = Convert.ToBoolean(dataGridView1.Rows[currentrow].Cells[6].Value.ToString()); //пишем в настройки параметр
                    Properties.Settings.Default.save = Convert.ToBoolean(dataGridView1.Rows[currentrow].Cells[7].Value.ToString()); //пишем в настройки параметр
                    Properties.Settings.Default.shifr = Convert.ToBoolean(dataGridView1.Rows[currentrow].Cells[8].Value.ToString()); //пишем в настройки параметр
                    if (dataGridView1.Rows[currentrow].Cells[5].Value.Equals(true)) //проверяем не заблочен ли он и если заблочен, то...
                    {
                        block = true; //ставим признак того, что он заблочен
                        break; //выходим из цикла
                    }
                }
                }

                if (check && !block) //если юзер зареган и не заблочен, то...
                {
                    string password = mTBPassword.Text; //считываем пароль, который ввели в поле
                    string hash = GetHashString(password); //хэшируем его
                    string userhash = dataGridView1.Rows[currentrow].Cells[2].Value.ToString(); //достаем хэшированный пароль юзера из БД
                    if (userhash == hash) //сравниваем хэши друг с другом...
                    {
                        FormMain fm = new FormMain(); //объявляем форму
                        fm.Show(); //допускаем пользователя к главной форме приложения
                        this.Hide(); //скрываем форму входа
                    }
                    else //если пользователь ввел неверный пароль...
                    {
                        if (counterblock >= 3) //если попытки ввода неправильного пароля достигли 3, то пишем в БД, что юзер заблочен...
                        {
                            string query = "UPDATE [user] SET [block]=true" + " WHERE [login]='" + login + "'"; //составляем запрос на обновление записи о юзере
                            MessageBox.Show(query);
                            cmd = new OleDbCommand(query, connect); //выполняем запрос
                            connect.Open();
                            cmd.ExecuteNonQuery();
                            connect.Close();
                            MessageBox.Show("Вы заблокированы! Обратитесь к администратору!"); //выводим инфу юзеру
                            Application.Restart(); //перезапускаем прогу, чтобы обновились данные в БД
                        }
                        else
                        {
                            counterblock++; //считаем кол-во раз неверно введенного пароля...
                            MessageBox.Show("Неверный пароль! Осталось попыток: " + Convert.ToString(3 - counterblock)); // выводим инфу о том сколько попыток у юзера осталось
                        }
                    }
                }
                else if(check && block) //если юзер зареган И заблочен...
                {
                    MessageBox.Show("Пользователь заблокирован! Обратитесь к администратору!"); //выводим инфу юзеру
                } //если пользователь не зареган, то предлаем зарегаться...
                else MessageBox.Show("Пользователь не найден! Зарегистрируйтесь!");
        }

        private void bRegister_Click(object sender, EventArgs e)
        {
            int index;
            index = Properties.Settings.Default.counter + 1;
            string hash = GetHashString(mTBPassword.Text);
            string fullname = tBName.Text;
            if (fullname == "") fullname = "UNKNOWN";
            string query = "INSERT INTO [user] ([id], [login], [password], [fullname], [type], [block], [open], [closing], [shifr_deshifr]) VALUES (";
            query += Convert.ToString(index) + ", '" + tBLogin.Text + "', '" +
                hash + "', '" + fullname + "', '" +
                "Пользователь" + "', False, " + "True" + ", " +
                "False" + ", " + "True" + ")";
            //label3.Text = query; //проверка запроса на правильность
            cmd = new OleDbCommand(query, connect);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Пользователь зарегистрирован! Программа перезапустится и вы сможете войти!");
            Application.Restart();
        }

        private void cBNewUser_CheckedChanged(object sender, EventArgs e)
        {
            if (cBNewUser.Checked)
            {
                bRegister.Enabled = true; //разрешаем доступ к кнопке Регистрация
                tBName.Visible = true; //показываем поле ввода имени пользователя
                label4.Visible = true; //показываем подпись к полю
            }
            else bRegister.Enabled = false; //запрещаем доступ к кнопке Регистрация
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|users.mdb");
            adapter = new OleDbDataAdapter("SELECT * FROM `user`", connect);
            ds = new DataSet();
            connect.Open();
            adapter.Fill(ds, "user");
            dataGridView1.DataSource = ds.Tables["user"];
            connect.Close();
            int max_id = 0;
            int count = dataGridView1.RowCount - 2; //ищем последнюю строку в таблице, чтобы к ней обратиться и взять оттуда последний id юзера
            for(int i = 0; i <= count; i++) //пробегаемся по таблице юзеров и ищем максимальный id, чтобы при регистрации не было совпадения записей
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value) > max_id) max_id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
            }
            Properties.Settings.Default.counter = max_id; //записываем в настройки найденный максимальный id юзера
            // TODO: данная строка кода позволяет загрузить данные в таблицу "usersDataSet1.user". При необходимости она может быть перемещена или удалена.
            //this.userTableAdapter.Fill(this.usersDataSet1.user);

        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
