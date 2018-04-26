using System;
using System.Collections.Generic;
using System.Text;

namespace MonetaryService.Abstractions
{
    public interface IMonetaryService
    {
        string ConvertNumericToText(double numericValue);
    }
}
