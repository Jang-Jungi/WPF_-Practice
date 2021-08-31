using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Practice
{
    class DataInfoNotify : INotifyPropertyChanged
    {
        private int _NumData = 100;
        public int NumData
        {
            get { return _NumData; }
            set
            {
                _NumData = value;
                OnPropertyChanged("NumData");
            }
        }

        public void DataPlus()
        {
            NumData++;
        }
        public void DataMinus()
        {
            NumData--;
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
