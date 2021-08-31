using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Practice
{
    class PersonalDetails
    {
        //변수 선언
        string _firstName = "Bob";
        string _lastName = "Smith";
        int _age = 25;

        
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }
}
