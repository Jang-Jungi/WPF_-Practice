using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_MahApps_Practice.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public bool IsBirthDay
        {
            get 
            {
                return DateTime.Now.Month == Date.Month &&
                        DateTime.Now.Day == Date.Day;
            }
        }
        //생성자 생성으로 바로 만들기 ALT+ENTER
        public Person(string firstName, string lastName, string email, DateTime date)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Date = date;
        }
    }
}
