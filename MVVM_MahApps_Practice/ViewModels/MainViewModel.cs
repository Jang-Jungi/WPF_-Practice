using MVVM_MahApps_Practice.Models;
using System;
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

        private string outAdult;
        private string outBirthday;
        private string outZodiac;
        private string outChnZodiac;

        #endregion

        #region ###Property 선언###
        public string InFirstName
        {
            get => inFirstName;
            //set => inFirstName = value; 를 써도 되지만 PropertyChanged 때문에 변경
            set
            {
                inFirstName = value;
                RaisePropertyChanged("InFirstName");
            }
        }
        public string InLastName
        {
            get => inLastName;
            set
            {
                inLastName = value;
                RaisePropertyChanged("InLastName");
            }
        }
        public string InEmail
        {
            get => inEmail;
            set
            {
                inEmail = value;
                RaisePropertyChanged("InEmail");
            }
        }
        public DateTime? InDate
        {
            get => inDate;
            set
            {
                inDate = value;
                RaisePropertyChanged("InDate");
            }
        }

        public string OutFirstName
        {
            get => outFirstName;
            set
            {
                outFirstName = value;
                RaisePropertyChanged("OutFirstName");
            }
        }

        public string OutLastName
        {
            get => outLastName;
            set
            {
                outLastName = value;
                RaisePropertyChanged("OutLastName");
            }
        }
        public string OutEmail
        {
            get => outEmail;
            set
            {
                outEmail = value;
                RaisePropertyChanged("OutEmail");
            }
        }
        public string OutDate
        {
            get => outDate;
            set
            {
                outDate = value;
                RaisePropertyChanged("OutDate");
            }
        }
        public string OutBirthDay
        {
            get => outBirthDay;
            set
            {
                outBirthDay = value;
                RaisePropertyChanged("OutBirthDay");
            }
        }
        public string OutAdult
        {
            get => outAdult;
            set
            {
                outAdult = value;
                RaisePropertyChanged("OutAdult");
            }
        }

        public string OutZodiac
        {
            get => outZodiac;
            set
            {
                outZodiac = value;
                RaisePropertyChanged("OutZodiac");
            }
        }
        public string OutChnZodiac
        {
            get => outChnZodiac;
            set
            {
                outChnZodiac = value;
                RaisePropertyChanged("OutChnZodiac");
            }
        }
        #endregion

        #region ###Command 처리

        ICommand clickCommand;
        public ICommand ClickCommand => clickCommand ?? (clickCommand = new RelayCommand<object>(o => Click(),o => IsClick()));
        

        private bool IsClick()
        {
            // Validation Check, 하나라도 누락되면 클릭 버튼이 안눌린다.
            return (!string.IsNullOrEmpty(InFirstName)) && 
                   (!string.IsNullOrEmpty(InLastName))  &&
                   (!string.IsNullOrEmpty(InEmail)) &&
                   (!string.IsNullOrEmpty(InDate.ToString())); 
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

                OutAdult     = person.IsAdult.ToString();
                OutZodiac    = person.Zodiac;
                OutChnZodiac = person.ChnZodiac;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"예외발생 : {ex.Message}");
            }
        } 
        #endregion
    }
}
