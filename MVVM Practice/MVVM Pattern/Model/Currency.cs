using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Practice.MVVM_Pattern.Model
{
    public class Currency
    {
        public Currency(string title, decimal rate)
        {
            Title = title;
            Rate = rate;
        }

        public string Title { get; set; }
        public decimal Rate { get; set; }
    }
}
