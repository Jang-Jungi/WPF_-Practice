using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Practice.Command
{
    public class RelayCommand : ICommand
    {
        #region Fields 
        readonly Action<object> _execute;
        #endregion // Fields 

        #region Constructors 
        public RelayCommand(Action<object> execute)
        {
            _execute = execute;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }
        #endregion // ICommand Members 
    }
}
