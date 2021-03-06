using MVVM_Practice.MVVM_Command.View;
using MVVM_Practice.MVVM_Pattern.View;
using MVVM_Practice.MVVMInteraction.View;
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

namespace MVVM_Practice
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
            MVVMPattern Window = new MVVMPattern();
            Window.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MVVMCommand Window = new MVVMCommand();
            Window.Show();
        }

        //private void Button_Click_2(object sender, RoutedEventArgs e)
        //{
        //    MVVMInteraction Window = new MVVMInteraction();
        //    Window.Show();
        //}
    }
}
