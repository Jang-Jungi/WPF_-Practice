using MVVM_MahApps_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MVVM_MahApps_Practice.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        #region ###변수 선언###
        private string inFirstName;
        private string inLastName;
        private string inEmail;
        private DateTime? inDate; //nullable

        private string outFirstName;
        private string outLastName;
        private string outEmail;
        private string outDate; //화면 출력은 string으로
        private string outBirthDay;
        #endregion

        #region ###Property 선언###
        public string InFirstName
        {
            get => inFirstName;
            //set => inFirstName = value; 를 써도 되지만 PropertyChanged 때문에 변경
            set
            {
                inFirstName = value;
                RaisePropertyChaged("InFirstName");
            }
        }
        public string InLastName
        {
            get => inLastName;
            set
            {
                inLastName = value;
                RaisePropertyChaged("InLastName");
            }
        }
        public string InEmail
        {
            get => inEmail;
            set
            {
                inEmail = value;
                RaisePropertyChaged("InEmail");
            }
        }
        public DateTime? InDate
        {
            get => inDate;
            set
            {
                inDate = value;
                RaisePropertyChaged("InDate");
            }
        }

        public string OutFirstName
        {
            get => outFirstName;
            set
            {
                outFirstName = value;
                RaisePropertyChaged("OutFirstName");
            }
        }

        public string OutLastName
        {
            get => outLastName;
            set
            {
                outLastName = value;
                RaisePropertyChaged("OutLastName");
            }
        }
        public string OutEmail
        {
            get => outEmail;
            set
            {
                outEmail = value;
                RaisePropertyChaged("OutEmail");
            }
        }
        public string OutDate
        {
            get => outDate;
            set
            {
                outDate = value;
                RaisePropertyChaged("OutDate");
            }
        }
        public string OutBirthDay
        {
            get => outBirthDay;
            set
            {
                outBirthDay = value;
                RaisePropertyChaged("OutBirthDay");
            }
        }
        #endregion

        #region ###Command 처리

        ICommand clickCommand;
        public ICommand ClickCommand => clickCommand ?? (clickCommand = new RelayCommand<object>(o => Click(),o => IsClick()));
        

        private bool IsClick()
        {
            return true; // Validation Check를 쉽고 간단하게 
        }
        private void Click()
        {
            try
            {
                // Person Model에서 데이터를 가져옴
                DateTime date = InDate ?? DateTime.Now;
                Person person = new Person(InFirstName, InLastName, InEmail, date);

                // 화면에 출력
                OutFirstName = person.FirstName;
                OutLastName  = person.LastName;
                OutEmail     = person.Email;
                OutDate      = person.Date.ToString("yyyy-MM-dd");
                OutBirthDay  = person.IsBirthDay.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"예외발생 : {ex.Message}");
            }
        } 
        #endregion
    }
}
