using MVVM_Practice.Command;
using MVVM_Practice.MVVM_Pattern.Model;
using System;
using System.Collections.Generic;

namespace MVVM_Practice.MVVM_Pattern.ViewModel
{
    class MVVMPatternViewModel : ViewModelBase
    {


        public MVVMPatternViewModel()
        {
            Currencies = new Currency[]
            {
                new Currency("US Dollar", 1.1M),
                new Currency("British Pound", 0.9M),
            };
        }

        private void OnEurosChanged()
        {
            ComputeConverted();
        }

        private void OnSelectedCurrencyChanged()
        {
            ComputeConverted();
        }

        private void ComputeConverted()
        {
            if (SelectedCurrency == null)
            {
                return;
            }
            Converted = Euros * SelectedCurrency.Rate;
            ResultText = String.Format("Amount in {0}", SelectedCurrency.Title);
        }


        #region # Property Declaration
        private decimal euros;
        public decimal Euros
        {
            get { return euros; }
            set
            {
                euros = value;
                OnPropertyChanged("Euros");
                OnEurosChanged();
            }
        }
        private decimal converted;
        public decimal Converted
        {
            get { return converted; }
            set
            {
                converted = value;
                OnPropertyChanged("Converted");
            }
        }

        private Currency selectedCurrency;
        public Currency SelectedCurrency
        {
            get { return selectedCurrency; }
            set
            {
                selectedCurrency = value;
                OnPropertyChanged("SelectedCurrency");
                OnSelectedCurrencyChanged();
            }
        }

        private IEnumerable<Currency> currencies;
        public IEnumerable<Currency> Currencies
        {
            get { return currencies; }
            set
            {
                currencies = value;
                OnPropertyChanged("Currencies");
            }
        }

        private string resultText;
        public string ResultText
        {
            get { return resultText; }
            set
            {
                resultText = value;
                OnPropertyChanged("ResultText");
            }
        }
        #endregion
    }
}
