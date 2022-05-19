using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.login = textBox1.Text;
            Properties.Settings.Default.password = textBox2.Text;
            Properties.Settings.Default.fullname = textBox3.Text;
            Properties.Settings.Default.type = comboBox1.Text;
            Properties.Settings.Default.open = checkBox1.Checked;
            Properties.Settings.Default.save = checkBox2.Checked;
            Properties.Settings.Default.shifr = checkBox3.Checked;
            this.Close();
        }
    }
}
