using MVVM_MahApps_Practice.Helpers;
using System;

namespace MVVM_MahApps_Practice.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private string email;
        public string Email 
        { 
            get => email;
            set
            {
                if (Commons.IsValidEmail(value))
                    email = value;
                else
                    throw new Exception("Invalid email");
            }
            
        }

        public DateTime date;
        public DateTime Date
        {
            get => date;
            set
            {
                int result = Commons.CalcAge(value);
                if (result > 135 || result < 0)
                    throw new Exception("Invalid date");
                else
                    date = value;
            }
        }

        public bool IsBirthDay => DateTime.Now.Month == Date.Month && DateTime.Now.Day == Date.Day;
        public bool IsAdult => Commons.CalcAge(date) > 18;
        public string Zodiac => Commons.CalcZodiac(date); 
        public string ChnZodiac => Commons.CalcChnZodiac(date);


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
