using Caliburn.Micro;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfCaliburnApp.ViewModels;

namespace WpfCaliburnApp
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();// Caliburn.Micr 초기화(필수!!)
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            // base.OnStartup(sender, e);
            DisplayRootViewFor<MainViewModel>();
        }

    }
}
