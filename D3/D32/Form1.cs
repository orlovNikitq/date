using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDate = startDatePicker.Value.Date;
            DateTime endDate = endDatePicker.Value.Date;
            TimeSpan difference = endDate - startDate;
            label3.Text = $"Разница в днях: {difference.Days} дней";
        }

    }
}
