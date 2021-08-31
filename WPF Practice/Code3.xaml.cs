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
    /// Code3.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Code3 : Window
    {
        public Code3()
        {
            InitializeComponent();
            //자기 자신을 바인딩 할 때 사용
            this.DataContext = this;

        }
    }
}
