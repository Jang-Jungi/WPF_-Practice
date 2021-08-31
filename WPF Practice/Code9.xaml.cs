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
    /// Code9.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Code9 : Window
    {
        List<User> _studentList = new List<User>();
        public List<User> studentList
        {
            get { return _studentList; }
            set
            {
                _studentList = value;
            }
        }

        List<User> _studentList_2 = new List<User>();
        public List<User> studentList_2
        {
            get { return _studentList_2; }
            set
            {
                _studentList_2 = value;
            }
        }

        public Code9()
        {
            InitializeComponent();

         
            studentList.Add(new User() { Name = "John Doe", Age = 42, Mail = "john@doe-family.com" });
            studentList.Add(new User() { Name = "Jane Doe", Age = 39, Mail = "jane@doe-family.com" });
            studentList.Add(new User() { Name = "Sammy Doe", Age = 13, Mail = "sammy.doe@gmail.com" });

            studentList_2.Add(new User() { Name = "John Doe", Age = 42, Mail = "john@doe-family.com" });
            studentList_2.Add(new User() { Name = "Jane Doe", Age = 39, Mail = "jane@doe-family.com" });
            studentList_2.Add(new User() { Name = "Sammy Doe", Age = 13, Mail = "sammy.doe@gmail.com" });

            this.ItemControl.ItemsSource = studentList;
            this.ListBox.ItemsSource = studentList;
            this.ListView.ItemsSource = studentList;
            this.ListView2.ItemsSource = studentList;
            this.DataGrid.ItemsSource = studentList_2;
        }

        public class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Mail { get; set; }
        }

    }
}
