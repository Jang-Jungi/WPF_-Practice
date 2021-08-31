using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Practice
{
    class StudentInfo
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

        public StudentInfo()
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
    }
}
