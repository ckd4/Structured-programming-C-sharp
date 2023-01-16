using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFA3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void B3_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder remadeString = new StringBuilder(); //хранение строки
            bool pointIsNotReached = true; //переменная для показателя достигнута точка или нет

            foreach (char symbol in TB3.Text)
            {
                switch (symbol)
                {
                    case '.': //Если встретилась точка, то булевая переменная меняет значение на false
                        pointIsNotReached = false;
                        remadeString.Append(symbol);
                        break;
                    case ',':
                        if(!pointIsNotReached)
                            remadeString.Append(symbol);
                        break;
                    case '-': //Если встретился -, то записывается +
                        remadeString.Append('+');
                        break;
                    default: //в остальных случаях символ добавляется в строку
                        remadeString.Append(symbol);
                        break;
                }
            }
            TB3.Text = remadeString.ToString(); //Итоговая строка записывается в Текстбокс
        }
    }
}
