using MVVM_Practice.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MVVM_Practice.MVVMInteraction.ViewModel
{
    class MVVMInteractionViewModel : ViewModelBase
    {

        private string _Text = "Black";
        public string Text
        {
            get { return _Text; }
            set
            {
                _Text = value;
                OnPropertyChanged("Text");
            }
        }

        private Brush _Color = Brushes.Black;
        public Brush Color
        {
            get { return _Color; }
            set
            {
                _Color = value;
                OnPropertyChanged("Color");
            }
        }

        public void RedGridOver()
        {
            Text = "Red";
            Color = Brushes.Red;
        }
        public void OrangeGridOver()
        {
            Text = "Orange";
            Color = Brushes.Orange;
        }
        public void YellowGridOver()
        {
            Text = "Yellow";
            Color = Brushes.Yellow;
        }
        public void GreenGridOver()
        {
            Text = "Green";
            Color = Brushes.Green;
        }
        public void BlueGridOver()
        {
            Text = "Blue";
            Color = Brushes.Blue;
        }
        public void NavyGridOver()
        {
            Text = "Navy";
            Color = Brushes.Navy;
        }
        public void PurpleGridOver()
        {
            Text = "Purple";
            Color = Brushes.Purple;
        }
        public void BlackButtonClick()
        {
            Text = "Black";
            Color = Brushes.Black;
        }
    }
}
