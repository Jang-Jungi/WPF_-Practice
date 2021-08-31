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
using System.Windows.Shapes;

namespace WPF_Practice
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Code1 Code = new Code1();
            Code.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Code2 Code = new Code2();
            Code.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Code3 Code = new Code3();
            Code.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Code4 Code = new Code4();
            Code.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Code5 Code = new Code5();
            Code.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Code6 Code = new Code6();
            Code.Show();
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Code7 Code = new Code7();
            Code.Show();
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Code8 Code = new Code8();
            Code.Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Code9 Code = new Code9();
            Code.Show();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Code10 Code = new Code10();
            Code.Show();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Code11 Code = new Code11();
            Code.Show();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Code12 Code = new Code12();
            Code.Show();
        }


    }
}
