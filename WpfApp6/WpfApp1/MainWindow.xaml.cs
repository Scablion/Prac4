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

            int n = int.Parse(N.Text);
            int i = 0, num;
            while(i < Convert.ToString(n).Length)
            {
                num = n % 10;
                n = n / 10;
                if (num == 7)
                {
                    Answer.Text = "True";
                    return;
                }
                i++;
            }
            Answer.Text = "False";

            
        }
    }
}
