using MonetaryService.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonetaryService.Services
{
    public class MonetaryService : IMonetaryService
    {
        private const string CENTS_STRING = " CENTS";
        private const string CENT_STRING = " CENT";
        private const string DOLLARS_STRING = " DOLLARS AND ";
        private const string DOLLAR_STRING = " DOLLAR AND ";
        private const string ZERO = " zero ";
        private const string ONE = " one ";
        private const string TWO = " two ";
        private const string THREE = " three ";
        private const string FOUR = " four ";
        private const string FIVE = " five ";
        private const string SIX = " six ";
        private const string SEVEN = " seven ";
        private const string EIGHT = " eight ";
        private const string NINE = " nine ";
        private const string TEN = " ten ";
        private const string ELEVEN = " eleven ";
        private const string TWELVE = " twelve ";
        private const string THIRTEEN = " thirteen ";
        private const string FOURTEEN = " fourteen ";
        private const string FIFTEEN = " fifteen ";
        private const string SIXTEEN = " sixteen ";
        private const string SEVENTEEN = " seventeen ";
        private const string EIGHTEEN = " eightteen ";
        private const string NINETEEN = " nineteen ";
        private const string TWENTY = " twenty ";
        private const string THIRTY = " thirty ";
        private const string FORTY = " forty ";
        private const string FIFTY = " fifty ";
        private const string SIXTY = " sixty ";
        private const string SEVENTY = " seventy ";
        private const string EIGHTY = " eighty ";
        private const string NINETY = " ninety ";
        private const string HUNDRED = " hundred and";
        private const string THOUSAND = " thousand, ";
        private const string MILLION = " million, ";


        public string ConvertNumericToText(double numericValue)
        {
            var resultString = string.Empty;

            // Convert numeric value to string
            string numericValueStr = Convert.ToString(numericValue);

            if (!numericValueStr.Contains("."))
            {
                numericValueStr += ".00";
            }

            // Separate integer value from decimals
            var numberComponents = numericValueStr.Split('.');

            // Check if decimal bit has only one digit which in that case add a zero at the end of the Array
            if (numberComponents[1].Length == 1)
            {
                numberComponents[1] += '0';
            }

            // Process integer value
            int lengthIntegerValue = numberComponents[0].Length;
            var integerNumbers = numberComponents[0].ToCharArray();
            var decimalNumbers = numberComponents[1].ToCharArray();

            switch (lengthIntegerValue)
            {
                case 7:
                    // Processing integer number
                    resultString += GetSingleNumberValue(Convert.ToInt16(integerNumbers[0].ToString()));
                    resultString += MILLION;
                    resultString += (Convert.ToInt16(integerNumbers[1].ToString()) == 0)
                        ? ""
                        : GetSingleNumberValue(Convert.ToInt16(integerNumbers[1].ToString())) + HUNDRED;

                    if (!(Convert.ToInt16(integerNumbers[2].ToString()) == 0))
                    {
                        resultString += Convert.ToInt16(integerNumbers[2].ToString()) == 1
                        ? GetTensValue(Convert.ToInt16(integerNumbers[2].ToString())
                            + Convert.ToInt16(integerNumbers[3].ToString()))
                            + THOUSAND
                        : GetTensValue(Convert.ToInt16(integerNumbers[2].ToString()))
                            + GetSingleNumberValue(Convert.ToInt16(integerNumbers[3].ToString()))
                            + THOUSAND;
                    }
                    else
                    {
                        resultString +=
                            GetSingleNumberValue(Convert.ToInt16(integerNumbers[3].ToString())) + THOUSAND;
                    }

                    resultString += (Convert.ToInt16(integerNumbers[4].ToString()) == 0)
                        ? ""
                        : GetSingleNumberValue(Convert.ToInt16(integerNumbers[4].ToString())) + HUNDRED;

                    if (!(Convert.ToInt16(integerNumbers[5].ToString()) == 0))
                    {
                        resultString += Convert.ToInt16(integerNumbers[5].ToString()) == 1
                        ? GetTensValue(Convert.ToInt16(integerNumbers[5].ToString())
                            + Convert.ToInt16(integerNumbers[6].ToString()))
                            + DOLLARS_STRING
                        : GetTensValue(Convert.ToInt16(integerNumbers[5].ToString()))
                            + GetSingleNumberValue(Convert.ToInt16(integerNumbers[6].ToString()))
                            + DOLLARS_STRING;
                    }
                    else
                    {
                        resultString += GetSingleNumberValue(Convert.ToInt16(integerNumbers[6].ToString()))
                            + DOLLARS_STRING;
                    }

                    // Processing cents
                    if (!(Convert.ToInt16(decimalNumbers[0].ToString()) == 0))
                    {
                        resultString += Convert.ToInt16(decimalNumbers[0].ToString()) == 1
                        ? GetTensValue(Convert.ToInt16(decimalNumbers[0].ToString() + decimalNumbers[1].ToString()))
                            + CENTS_STRING
                        : GetTensValue(Convert.ToInt16(decimalNumbers[0].ToString()))
                            + GetSingleNumberValue(Convert.ToInt16(decimalNumbers[1].ToString()))
                            + CENTS_STRING;
                    }
                    else
                    {
                        resultString += GetSingleNumberValue(Convert.ToInt16(decimalNumbers[1].ToString()))
                            + CENT_STRING;
                    }
                    break;

                case 6:
                    // Processing integer number
                    resultString += (Convert.ToInt16(integerNumbers[0].ToString()) == 0)
                        ? ""
                        : GetSingleNumberValue(Convert.ToInt16(integerNumbers[0].ToString())) + HUNDRED;

                    if (!(Convert.ToInt16(integerNumbers[1].ToString()) == 0))
                    {
                        resultString += Convert.ToInt16(integerNumbers[1].ToString()) == 1
                        ? GetTensValue(Convert.ToInt16(integerNumbers[1].ToString())
                            + Convert.ToInt16(integerNumbers[2].ToString()))
                            + THOUSAND
                        : GetTensValue(Convert.ToInt16(integerNumbers[1].ToString()))
                            + GetSingleNumberValue(Convert.ToInt16(integerNumbers[2].ToString()))
                            + THOUSAND;
                    }
                    else
                    {
                        resultString +=
                            GetSingleNumberValue(Convert.ToInt16(integerNumbers[2].ToString())) + THOUSAND;
                    }

                    resultString += (Convert.ToInt16(integerNumbers[3].ToString()) == 0)
                        ? ""
                        : GetSingleNumberValue(Convert.ToInt16(integerNumbers[3].ToString())) + HUNDRED;

                    if (!(Convert.ToInt16(integerNumbers[4].ToString()) == 0))
                    {
                        resultString += Convert.ToInt16(integerNumbers[4].ToString()) == 1
                        ? GetTensValue(Convert.ToInt16(integerNumbers[4].ToString())
                            + Convert.ToInt16(integerNumbers[5].ToString()))
                            + DOLLARS_STRING
                        : GetTensValue(Convert.ToInt16(integerNumbers[4].ToString()))
                            + GetSingleNumberValue(Convert.ToInt16(integerNumbers[5].ToString()))
                            + DOLLARS_STRING;
                    }
                    else
                    {
                        resultString += GetSingleNumberValue(Convert.ToInt16(integerNumbers[5].ToString()))
                            + DOLLARS_STRING;
                    }

                    // Processing cents
                    if (!(Convert.ToInt16(decimalNumbers[0].ToString()) == 0))
                    {
                        resultString += Convert.ToInt16(decimalNumbers[0].ToString()) == 1
                        ? GetTensValue(Convert.ToInt16(decimalNumbers[0].ToString() + decimalNumbers[1].ToString()))
                            + CENTS_STRING
                        : GetTensValue(Convert.ToInt16(decimalNumbers[0].ToString()))
                            + GetSingleNumberValue(Convert.ToInt16(decimalNumbers[1].ToString()))
                            + CENTS_STRING;
                    }
                    else
                    {
                        resultString += GetSingleNumberValue(Convert.ToInt16(decimalNumbers[1].ToString()))
                            + CENT_STRING;
                    }
                    break;

                case 5:
                    // Processing integer number
                    if (!(Convert.ToInt16(integerNumbers[0].ToString()) == 0))
                    {
                        resultString += Convert.ToInt16(integerNumbers[0].ToString()) == 1
                        ? GetTensValue(Convert.ToInt16(integerNumbers[0].ToString())
                            + Convert.ToInt16(integerNumbers[1].ToString()))
                            + THOUSAND
                        : GetTensValue(Convert.ToInt16(integerNumbers[0].ToString()))
                            + GetSingleNumberValue(Convert.ToInt16(integerNumbers[1].ToString()))
                            + THOUSAND;
                    }
                    else
                    {
                        resultString +=
                            GetSingleNumberValue(Convert.ToInt16(integerNumbers[1].ToString())) + THOUSAND;
                    }

                    resultString += (Convert.ToInt16(integerNumbers[2].ToString()) == 0)
                        ? ""
                        : GetSingleNumberValue(Convert.ToInt16(integerNumbers[2].ToString())) + HUNDRED;

                    if (!(Convert.ToInt16(integerNumbers[3].ToString()) == 0))
                    {
                        resultString += Convert.ToInt16(integerNumbers[3].ToString()) == 1
                        ? GetTensValue(Convert.ToInt16(integerNumbers[3].ToString())
                            + Convert.ToInt16(integerNumbers[4].ToString()))
                            + DOLLARS_STRING
                        : GetTensValue(Convert.ToInt16(integerNumbers[3].ToString()))
                            + GetSingleNumberValue(Convert.ToInt16(integerNumbers[4].ToString()))
                            + DOLLARS_STRING;
                    }
                    else
                    {
                        resultString += GetSingleNumberValue(Convert.ToInt16(integerNumbers[4].ToString()))
                            + DOLLARS_STRING;
                    }

                    // Processing cents
                    if (!(Convert.ToInt16(decimalNumbers[0].ToString()) == 0))
                    {
                        resultString += Convert.ToInt16(decimalNumbers[0].ToString()) == 1
                        ? GetTensValue(Convert.ToInt16(decimalNumbers[0].ToString() + decimalNumbers[1].ToString()))
                            + CENTS_STRING
                        : GetTensValue(Convert.ToInt16(decimalNumbers[0].ToString()))
                            + GetSingleNumberValue(Convert.ToInt16(decimalNumbers[1].ToString()))
                            + CENTS_STRING;
                    }
                    else
                    {
                        resultString += GetSingleNumberValue(Convert.ToInt16(decimalNumbers[1].ToString()))
                            + CENT_STRING;
                    }
                    break;

                case 4:
                    // Processing integer number
                    resultString +=
                            GetSingleNumberValue(Convert.ToInt16(integerNumbers[0].ToString())) + THOUSAND;

                    resultString += (Convert.ToInt16(integerNumbers[1].ToString()) == 0)
                        ? ""
                        : GetSingleNumberValue(Convert.ToInt16(integerNumbers[1].ToString())) + HUNDRED;

                    if (!(Convert.ToInt16(integerNumbers[2].ToString()) == 0))
                    {
                        resultString += Convert.ToInt16(integerNumbers[2].ToString()) == 1
                        ? GetTensValue(Convert.ToInt16(integerNumbers[2].ToString())
                            + Convert.ToInt16(integerNumbers[3].ToString()))
                            + DOLLARS_STRING
                        : GetTensValue(Convert.ToInt16(integerNumbers[2].ToString()))
                            + GetSingleNumberValue(Convert.ToInt16(integerNumbers[3].ToString()))
                            + DOLLARS_STRING;
                    }
                    else
                    {
                        resultString += GetSingleNumberValue(Convert.ToInt16(integerNumbers[3].ToString()))
                            + DOLLARS_STRING;
                    }

                    // Processing cents
                    if (!(Convert.ToInt16(decimalNumbers[0].ToString()) == 0))
                    {
                        resultString += Convert.ToInt16(decimalNumbers[0].ToString()) == 1
                        ? GetTensValue(Convert.ToInt16(decimalNumbers[0].ToString() + decimalNumbers[1].ToString()))
                            + CENTS_STRING
                        : GetTensValue(Convert.ToInt16(decimalNumbers[0].ToString()))
                            + GetSingleNumberValue(Convert.ToInt16(decimalNumbers[1].ToString()))
                            + CENTS_STRING;
                    }
                    else
                    {
                        resultString += GetSingleNumberValue(Convert.ToInt16(decimalNumbers[1].ToString()))
                            + CENT_STRING;
                    }
                    break;

                case 3:
                    // Processing integer number
                    resultString += (Convert.ToInt16(integerNumbers[0].ToString()) == 0)
                        ? ""
                        : GetSingleNumberValue(Convert.ToInt16(integerNumbers[0].ToString())) + HUNDRED;

                    if (!(Convert.ToInt16(integerNumbers[1].ToString()) == 0))
                    {
                        resultString += Convert.ToInt16(integerNumbers[1].ToString()) == 1
                        ? GetTensValue(Convert.ToInt16(integerNumbers[1].ToString())
                            + Convert.ToInt16(integerNumbers[2].ToString()))
                            + DOLLARS_STRING
                        : GetTensValue(Convert.ToInt16(integerNumbers[1].ToString()))
                            + GetSingleNumberValue(Convert.ToInt16(integerNumbers[2].ToString()))
                            + DOLLARS_STRING;
                    }
                    else
                    {
                        resultString += GetSingleNumberValue(Convert.ToInt16(integerNumbers[2].ToString()))
                            + DOLLARS_STRING;
                    }

                    // Processing cents
                    if (!(Convert.ToInt16(decimalNumbers[0].ToString()) == 0))
                    {
                        resultString += Convert.ToInt16(decimalNumbers[0].ToString()) == 1
                        ? GetTensValue(Convert.ToInt16(decimalNumbers[0].ToString() + decimalNumbers[1].ToString()))
                            + CENTS_STRING
                        : GetTensValue(Convert.ToInt16(decimalNumbers[0].ToString()))
                            + GetSingleNumberValue(Convert.ToInt16(decimalNumbers[1].ToString()))
                            + CENTS_STRING;
                    }
                    else
                    {
                        resultString += GetSingleNumberValue(Convert.ToInt16(decimalNumbers[1].ToString()))
                            + CENT_STRING;
                    }
                    break;

                case 2:
                    // Processing integer number
                    if (!(Convert.ToInt16(integerNumbers[0].ToString()) == 0))
                    {
                        resultString += Convert.ToInt16(integerNumbers[0].ToString()) == 1
                        ? GetTensValue(Convert.ToInt16(integerNumbers[0].ToString())
                            + Convert.ToInt16(integerNumbers[1].ToString()))
                            + DOLLARS_STRING
                        : GetTensValue(Convert.ToInt16(integerNumbers[0].ToString()))
                            + GetSingleNumberValue(Convert.ToInt16(integerNumbers[1].ToString()))
                            + DOLLARS_STRING;
                    }
                    else
                    {
                        resultString += GetSingleNumberValue(Convert.ToInt16(integerNumbers[1].ToString()))
                            + DOLLARS_STRING;
                    }

                    // Processing cents
                    if (!(Convert.ToInt16(decimalNumbers[0].ToString()) == 0))
                    {
                        resultString += Convert.ToInt16(decimalNumbers[0].ToString()) == 1
                        ? GetTensValue(Convert.ToInt16(decimalNumbers[0].ToString() + decimalNumbers[1].ToString()))
                            + CENTS_STRING
                        : GetTensValue(Convert.ToInt16(decimalNumbers[0].ToString()))
                            + GetSingleNumberValue(Convert.ToInt16(decimalNumbers[1].ToString()))
                            + CENTS_STRING;
                    }
                    else
                    {
                        resultString += GetSingleNumberValue(Convert.ToInt16(decimalNumbers[1].ToString()))
                            + CENT_STRING;
                    }
                    break;

                case 1:
                    // Processing integer number
                    resultString += Convert.ToInt16(integerNumbers[0].ToString()) == 1
                        ? GetSingleNumberValue(Convert.ToInt16(integerNumbers[0].ToString()))
                            + DOLLAR_STRING
                        : GetSingleNumberValue(Convert.ToInt16(integerNumbers[0].ToString()))
                            + DOLLARS_STRING;

                    // Processing cents
                    if (!(Convert.ToInt16(decimalNumbers[0].ToString()) == 0))
                    {
                        resultString += Convert.ToInt16(decimalNumbers[0].ToString()) == 1
                        ? GetTensValue(Convert.ToInt16(decimalNumbers[0].ToString() + decimalNumbers[1].ToString()))
                            + CENTS_STRING
                        : GetTensValue(Convert.ToInt16(decimalNumbers[0].ToString()))
                            + GetSingleNumberValue(Convert.ToInt16(decimalNumbers[1].ToString()))
                            + CENTS_STRING;
                    }
                    else
                    {
                        resultString += GetSingleNumberValue(Convert.ToInt16(decimalNumbers[1].ToString()))
                            + CENT_STRING;
                    }
                    break;

                default:
                    break;
            }

            return resultString;
        }

        private string GetSingleNumberValue(int num)
        {
            if (num == 1)
            {
                return ONE;
            }
            else if (num == 2)
            {
                return TWO;
            }
            else if (num == 3)
            {
                return THREE;
            }
            else if (num == 4)
            {
                return FOUR;
            }
            else if (num == 5)
            {
                return FIVE;
            }
            else if (num == 6)
            {
                return SIX;
            }
            else if (num == 7)
            {
                return SEVEN;
            }
            else if (num == 8)
            {
                return EIGHT;
            }
            else if (num == 9)
            {
                return NINE;
            }
            else if (num == 0)
            {
                return ZERO;
            }
            else
            {
                return "ND";
            }
        }

        private string GetTensValue(int num)
        {
            if (num == 10)
            {
                return TEN;
            }
            else if (num == 11)
            {
                return ELEVEN;
            }
            else if (num == 12)
            {
                return TWELVE;
            }
            else if (num == 13)
            {
                return THIRTEEN;
            }
            else if (num == 14)
            {
                return FOURTEEN;
            }
            else if (num == 15)
            {
                return FIFTEEN;
            }
            else if (num == 16)
            {
                return SIXTEEN;
            }
            else if (num == 17)
            {
                return SEVENTEEN;
            }
            else if (num == 18)
            {
                return EIGHTEEN;
            }
            else if (num == 19)
            {
                return NINETEEN;
            }
            else if (num == 2)
            {
                return TWENTY;
            }
            else if (num == 3)
            {
                return THIRTY;
            }
            else if (num == 4)
            {
                return FORTY;
            }
            else if (num == 5)
            {
                return FIFTY;
            }
            else if (num == 6)
            {
                return SIXTY;
            }
            else if (num == 7)
            {
                return SEVENTY;
            }
            else if (num == 8)
            {
                return EIGHTY;
            }
            else if (num == 9)
            {
                return NINETY;
            }
            else
            {
                return "ND";
            }
        }
    }
}
