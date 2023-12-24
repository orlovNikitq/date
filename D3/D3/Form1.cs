using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("SaveFile.txt",false))
            {
                sw.WriteLine($"Surname: {Surname.Text}; Name: {Name.Text}; Patronymic: {Patronymic.Text}; Gender: {Gender.Text}; Date of birth: {Date_of_birth.Text}; Family status: {Family_status.Text}; Additional information: {Additional_information.Text}.");
            }
            MessageBox.Show("Данные успешно сохранены");
        }
    }
}
