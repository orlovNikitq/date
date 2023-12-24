using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int day);
            int.TryParse(textBox2.Text, out int month);
            int.TryParse(textBox3.Text, out int year);
          
            if (day > 31 || month > 12 || textBox3.Text.Length != 4 || year < 1753)
            {
                MessageBox.Show("Введите корректные значения");
            }
            else dateTimePicker1.Value = new DateTime(year,month, day);
        }
    }
}
