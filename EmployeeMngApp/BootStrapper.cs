using Caliburn.Micro;
using EmployeeMngApp.ViewModels;
using System.Windows;

namespace EmployeeMngApp
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();// Caliburn.Micr 초기화(필수!!)
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            //base.OnStartup(sender, e);
            DisplayRootViewFor<MainViewModel>();
        }

    }
}