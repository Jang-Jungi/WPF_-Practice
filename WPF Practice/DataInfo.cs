using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Practice
{
    public class DataInfo
    {
        private int _NumData = 100;
        public int NumData
        {
            get { return _NumData; }
            set
            {
                _NumData = value;
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

    }
}
