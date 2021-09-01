using MVVM_Practice.MVVMInteraction.ViewModel;
using System.Windows;

namespace MVVM_Practice.MVVMInteraction.View
{
    /// <summary>
    /// MVVMInteraction.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MVVMInteraction : Window
    {
        MVVMInteractionViewModel MVVMInteractionVM = new MVVMInteractionViewModel();
        public MVVMInteraction()
        {
            InitializeComponent();
            this.DataContext = MVVMInteractionVM;
        }
    }
}
