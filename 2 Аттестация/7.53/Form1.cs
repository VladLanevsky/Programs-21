using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolsLibrary;

namespace _7._53
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int[] Arr = ArrConverter.StrToArray<int>(ArrInput.Text);
                ArrayTls arrayTls = new ArrayTls(Arr);
                int output = arrayTls.GetIndexOfFrequent();
                ArrOutput.Text = output.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода", "ошибка");
            }
        }
    }
}
