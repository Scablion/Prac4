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
            int dd = int.Parse(DD.Text);
            int mm = int.Parse(MM.Text);
            if (mm == 1 && dd == 1)
            {
                mm = 12;
                dd = 31;
                Answer.Text = $"Вчера было:\n {dd}.{mm}";
            }
            else if (mm != 3 && mm % 2 != 0)
            {
                switch (dd)
                {
                    case 1:
                        dd = 31;
                        mm -= 1;
                        Answer.Text = $"Вчера было:\n {dd}.{mm}";
                        return;

                    default:
                        dd -= 1;
                        Answer.Text = $"Вчера было:\n {dd}/{mm}";
                        return;
                }
            }
            else if (mm != 3 && mm % 2 == 0)
            {
                switch (dd)
                {
                    case 1:
                        mm -= 1;
                        dd = 30;
                        Answer.Text = $"Вчера было:\n {dd}.{mm}";
                        return;
                    default:
                        dd -= 1;
                        Answer.Text = $"Вчера было:\n {dd}.{mm}";
                        return;
                }
            }
            else
            {
                switch (dd)
                {
                    case 1:
                        mm -= 1;
                        dd = 28;
                        Answer.Text = $"Вчера было:\n {dd}.{mm}";
                        return;
                    default:
                        dd -= 1;
                        Answer.Text = $"Вчера было:\n {dd}.{mm}";
                        return;
                }
            }            
 
        }
    }
}
