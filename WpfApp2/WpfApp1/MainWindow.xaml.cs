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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int yy = int.Parse(YY.Text);
            string[] Days = { "Двадцать ", "Тридцать ", "Сорок", "Пятьдесят ", "Шестьдесят " };
            string[] years = { "один год", "два года", "три года", "четыре года", "пять лет", "шесть лет", "семь лет", "восемь лет", "девять лет" };
            int fn = yy / 10, sn = yy % 10;
            string Str = "";

            switch (fn)
            {
                case 2:
                    Str += Days[0];
                    break;
                case 3:
                    Str += Days[1];
                    break;
                case 4:
                    Str += Days[2];
                    break;
                case 5:
                    Str += Days[3];
                    break;
                case 6:
                    Str += Days[4];
                    break;
                default:
                    Str = "Uncorrect mean.";
                    return;
            }

            switch (sn)
            {
                case 1:
                    Str += years[0];
                    break;
                case 2:
                    Str += years[1];
                    break;
                case 3:
                    Str += years[2];
                    break;
                case 4:
                    Str += years[3];
                    break;
                case 5:
                    Str += years[4];
                    break;
                case 6:
                    Str += years[5];
                    break;
                case 7:
                    Str += years[6];
                    break;
                case 8:
                    Str += years[7];
                    break;
                case 9:
                    Str += years[8];
                    break;
                default:
                    Str += "лет.";
                    break;
            }

            

            Answer.Text = Str;

        }
    }
}
