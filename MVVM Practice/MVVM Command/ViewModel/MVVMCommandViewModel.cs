using MVVM_Practice.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MVVM_Practice.MVVM_Command.ViewModel
{
    class MVVMCommandViewModel
    {
        public ICommand ExecuteClick { get; set; }

        public MVVMCommandViewModel()
        {
            ExecuteClick = new RelayCommand(executefuction);
        }

        public void executefuction(object arg)
        {
            MessageBox.Show("Command Binding OK!!");
        }
    }
}
