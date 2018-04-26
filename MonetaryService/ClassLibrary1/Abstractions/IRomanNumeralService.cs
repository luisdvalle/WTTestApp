using System;
using System.Collections.Generic;
using System.Text;

namespace MonetaryService.Abstractions
{
    public interface IRomanNumeralService
    {
        string ConvertNumericToRoman(int numericValue);
        int ConvertRomanToNumeric(string romanValue);
    }
}
