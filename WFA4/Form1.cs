using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            StringBuilder resultString1 = new StringBuilder();
            StringBuilder resultString2 = new StringBuilder();

            if (tbToCompare1.Text.Length < 15) /*Если первая строка короче 15 символов, 
                                                то в строку записывается каждый второй символ, начиная с чётного*/
            {
                for (int i = 0; i < tbToCompare2.Text.Length; i = i + 2)
                    resultString1.Append("" + tbToCompare2.Text[i]);
                lblOut.Text = resultString1.ToString(); //Итоговая строка записывается в метку
            }
            else //Иначе сохраняется исходная строка
                resultString1.Append(tbToCompare1.Text);

            if (tbToCompare2.Text.Length > 30) /*Если вторая строка длиннее 30 символов,
                                               то в строку записывается каждый второй символ, начиная с нечётного*/
            {
                for (int i = 1; i < tbToCompare1.Text.Length; i = i + 2)
                    resultString2.Append("" + tbToCompare1.Text[i]);
                lblOut.Text = resultString2.ToString(); //Итоговая строка записывается в метку
            }
            else
                resultString2.Append(tbToCompare2.Text);
        }
    }
}
