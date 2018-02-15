using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            str = textBox1.Text;
            if (str.Contains("ш") && str.Contains("и") && str.Contains("н") && str.Contains("а"))
                MessageBox.Show("Из данной строки можно составить слово Шина");
            else
                MessageBox.Show("Из данной строки нельзя составить слово Шина");
        }
    }
}
