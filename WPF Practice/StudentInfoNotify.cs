using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Practice
{
    class StudentInfoNotify : INotifyPropertyChanged
    {
        ObservableCollection<User> _studentList = new ObservableCollection<User>();
        public ObservableCollection<User> studentList
        {
            get { return _studentList; }
            set
            {
                _studentList = value;
            }
        }

        ObservableCollection<User> _studentList_2 = new ObservableCollection<User>();
        public ObservableCollection<User> studentList_2
        {
            get { return _studentList_2; }
            set
            {
                _studentList_2 = value;
            }
        }

        private string _Name;
        public string UserName
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged("UserName");
            }
        }
        private string _Age;
        public string UserAge
        {
            get { return _Age; }
            set
            {
                _Age = value;
                OnPropertyChanged("UserAge");
            }
        }
        private string _Mail;
        public string UserMail
        {
            get { return _Mail; }
            set
            {
                _Mail = value;
                OnPropertyChanged("UserMail");
            }
        }

        public StudentInfoNotify()
        {
            studentList.Add(new User() { Name = "John Doe", Age = "42", Mail = "john@doe-family.com" });
            studentList.Add(new User() { Name = "Jane Doe", Age = "39", Mail = "jane@doe-family.com" });
            studentList.Add(new User() { Name = "Sammy Doe", Age = "13", Mail = "sammy.doe@gmail.com" });

            studentList_2.Add(new User() { Name = "John Doe", Age = "42", Mail = "john@doe-family.com" });
            studentList_2.Add(new User() { Name = "Jane Doe", Age = "39", Mail = "jane@doe-family.com" });
            studentList_2.Add(new User() { Name = "Sammy Doe", Age = "13", Mail = "sammy.doe@gmail.com" });
        }

        public class User
        {
            public string Name { get; set; }
            public string Age { get; set; }
            public string Mail { get; set; }
        }

        public void AddUser(string name, string age, string mail)
        {
            studentList.Add(new User() { Name = name, Age = age, Mail = mail });
            studentList_2.Add(new User() { Name = name, Age = age, Mail = mail });
        }
        public void AddUser()
        {
            studentList.Add(new User() { Name = UserName, Age = UserAge, Mail = UserMail });
            studentList_2.Add(new User() { Name = UserName, Age = UserAge, Mail = UserMail });
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
