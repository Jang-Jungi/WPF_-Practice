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
    /// Code10.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Code10 : Window
    {
        DataInfo datainfo = new DataInfo();
        public Code10()
        {
            InitializeComponent();
            this.DataContext = datainfo;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            datainfo.DataPlus();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            datainfo.DataMinus();
        }
        // UI 에서 이 변하지 않음  --> Notifier 사용

    }
}
