using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSetting fs = new FormSetting();
            fs.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.Show();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename; //открытие файла
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                label4.Text = Path.GetExtension(openFileDialog1.FileName);
                label3.Text = filename;
                StreamReader sr = new StreamReader(filename, Encoding.UTF8);
                string text = sr.ReadToEnd();
                rTBOriginal.AppendText(text);
                button1.Enabled = true;
                sr.Close();
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTBOriginal.SaveFile(label3.Text, RichTextBoxStreamType.PlainText);
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "*.ttd"; //сохранение файла
            saveFileDialog1.Filter = "Зашифрованный файл tte|*.tte|Нешифрованный файл ttd|*.ttd";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.UTF8);
                sw.WriteLine(rTBOriginal.Text);
                sw.Close();
                //rTBOriginal.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //очищаем поля
            rTBOriginal.Clear();
            rTBEdit.Clear();
        }

        private void оригинальныйТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //очищаем поля
            rTBOriginal.Clear();
        }

        private void редактированныйТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //очищаем поля
            rTBEdit.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label4.Text == ".ttd")
            {
                var cipher = new VigenereCipher("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя");
                var inputText = rTBOriginal.Text;
                var password = "КЛЮЧ";
                var encryptedText = cipher.Encrypt(inputText, password);
                rTBEdit.Text = encryptedText;
            }
            else if (label4.Text == ".tte")
            {
                var cipher = new VigenereCipher("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя");
                var encryptedText = rTBOriginal.Text;
                var password = "КЛЮЧ";
                rTBEdit.Text = cipher.Decrypt(encryptedText, password);
            }
            else
            {
                var cipher = new VigenereCipher("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя");
                var inputText = rTBOriginal.Text;
                var password = "КЛЮЧ";
                var encryptedText = cipher.Encrypt(inputText, password);
                rTBEdit.Text = encryptedText;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //при загрузке формы выставляем все настройки, того юзера, что залогинился и считываем его данные, записывая их в настройки
            label1.Text = "Пользователь: " + Properties.Settings.Default.fullname + "(Тип: " + Properties.Settings.Default.type + ")";
            bool save = Convert.ToBoolean(Properties.Settings.Default.edit_closing.ToString());
            bool open = Convert.ToBoolean(Properties.Settings.Default.open.ToString());
            bool shifr = Convert.ToBoolean(Properties.Settings.Default.shifr.ToString());
            openFileDialog1.Filter = "Зашифрованный файл tte|*.tte|Нешифрованный файл ttd|*.ttd";
            if (Properties.Settings.Default.shifr == false)
            {
                дешифроватьToolStripMenuItem.Enabled = false;
                button1.Enabled = false;
            }
            if (Properties.Settings.Default.open == false)
            {
                открытьToolStripMenuItem.Enabled = false;
            }
            if (Properties.Settings.Default.save == false)
            {
                сохранитьToolStripMenuItem.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rTBOriginal.Clear();
            rTBOriginal.Text = rTBEdit.Text;
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //закрываем файл
            label3.Text = "";
            label4.Text = "";
            rTBEdit.Clear();
            rTBOriginal.Clear();
            button1.Enabled = false;
        }

        private void rTBOriginal_TextChanged(object sender, EventArgs e)
        {
            if (rTBOriginal.Text.Length > 0) button1.Enabled = true;
            else button1.Enabled = false;
        }

        private void зашифроватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //шифируем текст
            if (rTBOriginal.Text.Length > 0)
            {
                var cipher = new VigenereCipher("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя");
                var inputText = rTBOriginal.Text;
                var password = "КЛЮЧ";
                var encryptedText = cipher.Encrypt(inputText, password);
                rTBEdit.Text = encryptedText;
            }
            else MessageBox.Show("Текст пуст!");
        }

        private void дешифроватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //дешифруем текст
            if (rTBOriginal.Text.Length > 0)
            {
                var cipher = new VigenereCipher("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя");
                var encryptedText = rTBOriginal.Text;
                var password = "КЛЮЧ";
                rTBEdit.Text = cipher.Decrypt(encryptedText, password);
            }
            else MessageBox.Show("Текст пуст!");
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.Show();
            this.Hide();
        }

        private void всеПоляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //очищаем поля
            rTBOriginal.Clear();
            rTBEdit.Clear();
        }
    }
    public class VigenereCipher
    {
        const string defaultAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        readonly string letters;
        public VigenereCipher(string alphabet = null)
        {
            //помещаем переданный алфавит
            letters = string.IsNullOrEmpty(alphabet) ? defaultAlphabet : alphabet;
        }
        //генерация повторяющегося пароля
        private string GetRepeatKey(string s, int n)
        {
            var p = s;
            while (p.Length < n)
            {
                p += p;
            }
            return p.Substring(0, n);
        }
        private string Vigenere(string text, string password, bool encrypting = true)
        {
            var gamma = GetRepeatKey(password, text.Length);
            var retValue = "";
            var q = letters.Length;
            for (int i = 0; i < text.Length; i++)
            {
                var letterIndex = letters.IndexOf(text[i]);
                var codeIndex = letters.IndexOf(gamma[i]);
                if (letterIndex < 0)
                {
                    //если буква не найдена, добавляем её в исходном виде
                    retValue += text[i].ToString();
                }
                else
                {
                    retValue += letters[(q + letterIndex + ((encrypting ? 1 : -1) * codeIndex)) % q].ToString();
                }
            }
            return retValue;
        }
        //шифрование текста
        public string Encrypt(string plainMessage, string password)
            => Vigenere(plainMessage, password);

        //дешифрование текста
        public string Decrypt(string encryptedMessage, string password)
            => Vigenere(encryptedMessage, password, false);
    }

    
}
