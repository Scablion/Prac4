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
using static System.Math;


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

            int P = int.Parse(Proc.Text), count = 0;
            double sum = 1000 ;
            if (P > 0 && P < 25)
            {

            
                while (sum < 1100)
                {
                    sum = sum + sum / 100 * P;
                    count++;
                }
                Answer.Text = $"Сумма достигнет 1100 \nчерез {count} месяцев\nИтоговый размер\n вклада = {sum:f2}";
            }
            else
                Answer.Text = "Процент не должен\n превышать 25";

            
        }
    }
}
