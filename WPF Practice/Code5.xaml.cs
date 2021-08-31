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
    /// Code5.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Code5 : Window
    {
        public Code5()
        {
            InitializeComponent();
        }
    }

    public class YesNoToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            /******************사용자 편집 영역*****************************/
            switch (value.ToString().ToLower())
            {
                case "yes":
                    return true;
                case "no":
                    return false;
            }
            return false;
            /*******************사용자 편집 영역****************************/
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            /*******************사용자 편집 영역****************************/
            if (value is bool)
            {
                if ((bool)value == true)
                    return "yes";
                else
                    return "no";
            }
            return "no";
            /*******************사용자 편집 영역****************************/

        }
    }

    public class ValueToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            /******************사용자 편집 영역*****************************/
            double dValue = System.Convert.ToDouble(value);
            if (dValue == 0)
            {
                return Brushes.Red;
            }
            else if (dValue > 0 && dValue < 3)
            {
                return Brushes.Orange;
            }
            else if (dValue >= 3 && dValue < 6)
            {
                return Brushes.Yellow;
            }
            else if (dValue >= 6 && dValue < 9)
            {
                return Brushes.Green;
            }
            else
            {
                return Brushes.Blue;
            }
            /*******************사용자 편집 영역****************************/
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            /*******************사용자 편집 영역****************************/
            return null;
            /*******************사용자 편집 영역****************************/
        }
    }
}
