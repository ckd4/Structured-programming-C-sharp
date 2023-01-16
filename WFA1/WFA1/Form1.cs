using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Runtime;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WFA1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            //обработка пустых текстбоксов
            if (!string.IsNullOrEmpty(tbr.Text) && !string.IsNullOrEmpty(tbp.Text))
            {
                //случай если первый текстбокс длиннее
                if (tbp.TextLength > tbr.TextLength)
                {
                    int counterP = 0;
                    int counterR = 0;
                    //подсчет буквы П в ведденном тексте
                    for (int i = 0; i < tbp.TextLength; i++)
                    {
                        if (tbp.Text.Substring(i, 1).ToLower() == "п")
                            counterP++;
                    }
                    //подсчет буквы Р в ведденном тексте
                    for (int k = 0; k < tbr.TextLength; k++)
                    {
                        if (tbr.Text.Substring(k, 1).ToLower() == "р")
                            counterR++;
                    }

                    lblP.Text = Convert.ToString(counterP);
                    lblR.Text = Convert.ToString(counterR);
                }
                //случай если второй текстбокс длиннее
                else
                {
                    int counter1 = 0;
                    int counter2 = 0;
                    for (int i = 0; i < tbp.TextLength; i++)
                    {
                        if (tbp.Text.Substring(i, 1).ToLower() == "р")
                            counter1++;
                    }

                    for (int k = 0; k < tbr.TextLength; k++)
                    {
                        if (tbr.Text.Substring(k, 1).ToLower() == "п")
                            counter2++;
                    }

                    //вывод значений в лэйблы
                    lblP.Text = Convert.ToString(counter1);
                    lblR.Text = Convert.ToString(counter2);
                }
            }
            else
            {
                MessageBox.Show("Введите корректные значения!", "Ошибка");
            }

        }
    }
}
