using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WTBankWebApp.ViewModels
{
    public class MonetaryFigureViewModel
    {
        //[Required]
        public double? NumericValue { get; set; }
        public string EnglishTextValue { get; set; }
    }
}
