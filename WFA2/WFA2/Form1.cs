using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //обработка пустых текстбоксов
            if (!string.IsNullOrEmpty(TBCheck.Text))
            {
                try
                {
                    //вывод преобразованной строки, получение индекса первой ';' и последующее обрезание до следующей ';'
                    TBCheck.Text = $"{TBCheck.Text.Substring(TBCheck.Text.IndexOf(';') + 1, TBCheck.Text.Length - TBCheck.Text.LastIndexOf(';') - 1)}";
                }
                //обработка неправильного формата
                catch
                {
                    MessageBox.Show("Неправильный формат либо строка уже была получена!");
                }
            }
            //обработка пустых текстбоксов
            else
            {
                MessageBox.Show("Введите строку!");
            }
        }
    }
}
