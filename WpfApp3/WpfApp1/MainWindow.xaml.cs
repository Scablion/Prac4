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

            int num = int.Parse(Num.Text);
            int mean = int.Parse(Mean.Text);
            double R, D, L, S;

            switch (num)
            {
                case 1:
                    R = int.Parse(Mean.Text);
                    D = 2 * R;
                    L = 2 * 3.14 * R;
                    S = 3.14 * Pow(R, 2);
                    break;
                case 2:
                    D = int.Parse(Mean.Text);
                    R = D / 2;
                    L = 2 * 3.14 * R;
                    S = 3.14 * Pow(R,2);
                    break;
                case 3:
                    L = int.Parse(Mean.Text);
                    R = L / 2 / 3.14;
                    S = 3.14 * Pow(R, 2);
                    D = 2 * R;
                    break;
                case 4:
                    S = int.Parse(Mean.Text);
                    R = Sqrt(S / 3.14);
                    D = 2 * R;
                    L = 2 * 3.14 * R;
                    break;
                default:
                    return;
            }
            Answer.Text = $"R = {R:f3}\n D = {D:f3}\n L = {L:f3}\n S = {S:f3}"; 
        }
    }
}
