using MonetaryService.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonetaryService.Services
{
    public class RomanNumeralService : IRomanNumeralService
    {
        public string ConvertNumericToRoman(int numericValue)
        {
            var resultString = string.Empty;

            // Convert numeric value to string
            string numericValueStr = Convert.ToString(numericValue);

            int lengthNumericValue = numericValueStr.Length;
            var integerNumbers = numericValueStr.ToCharArray();

            switch (lengthNumericValue)
            {
                case 4:
                    int number = Convert.ToInt16(integerNumbers[0].ToString());
                    for (int i = 1; i <= number; i++)
                    {
                        resultString += NumericToRomanMapping.M;
                    }

                    number = Convert.ToInt16(integerNumbers[1].ToString());
                    if (number == 0)
                    {
                        // Do nothing.
                    }
                    else if (number == 5)
                    {
                        resultString += NumericToRomanMapping.D;
                    }
                    else if (number > 5)
                    {
                        if (number == 9)
                        {
                            resultString += NumericToRomanMapping.C;
                            resultString += NumericToRomanMapping.M;
                        }
                        else
                        {
                            resultString += NumericToRomanMapping.D;
                            for (int i = 6; i <= number; i++)
                            {
                                resultString += NumericToRomanMapping.C;
                            }
                        }
                    }
                    else
                    {
                        if (number == 4)
                        {
                            resultString += NumericToRomanMapping.C;
                            resultString += NumericToRomanMapping.D;
                        }
                        else
                        {
                            for (int i = 1; i <= number; i++)
                            {
                                resultString += NumericToRomanMapping.C;
                            }
                        }
                    }

                    number = Convert.ToInt16(integerNumbers[2].ToString());
                    if (number == 0)
                    {
                        // Do nothing.
                    }
                    else if (number == 5)
                    {
                        resultString += NumericToRomanMapping.L;
                    }
                    else if (number > 5)
                    {
                        if (number == 9)
                        {
                            resultString += NumericToRomanMapping.X;
                            resultString += NumericToRomanMapping.C;
                        }
                        else
                        {
                            resultString += NumericToRomanMapping.L;
                            for (int i = 6; i <= number; i++)
                            {
                                resultString += NumericToRomanMapping.X;
                            }
                        }
                    }
                    else
                    {
                        if (number == 4)
                        {
                            resultString += NumericToRomanMapping.X;
                            resultString += NumericToRomanMapping.L;
                        }
                        else
                        {
                            for (int i = 1; i <= number; i++)
                            {
                                resultString += NumericToRomanMapping.X;
                            }
                        }
                    }

                    number = Convert.ToInt16(integerNumbers[3].ToString());
                    if (number == 0)
                    {
                        // Do nothing.
                    }
                    else if (number == 5)
                    {
                        resultString += NumericToRomanMapping.V;
                    }
                    else if (number > 5)
                    {
                        if (number == 9)
                        {
                            resultString += NumericToRomanMapping.I;
                            resultString += NumericToRomanMapping.X;
                        }
                        else
                        {
                            resultString += NumericToRomanMapping.V;
                            for (int i = 6; i <= number; i++)
                            {
                                resultString += NumericToRomanMapping.I;
                            }
                        }
                    }
                    else
                    {
                        if (number == 4)
                        {
                            resultString += NumericToRomanMapping.I;
                            resultString += NumericToRomanMapping.V;
                        }
                        else
                        {
                            for (int i = 1; i <= number; i++)
                            {
                                resultString += NumericToRomanMapping.I;
                            }
                        }
                    }

                    break;

                case 3:
                    number = Convert.ToInt16(integerNumbers[0].ToString());
                    if (number == 0)
                    {
                        // Do nothing.
                    }
                    else if (number == 5)
                    {
                        resultString += NumericToRomanMapping.D;
                    }
                    else if (number > 5)
                    {
                        if (number == 9)
                        {
                            resultString += NumericToRomanMapping.C;
                            resultString += NumericToRomanMapping.M;
                        }
                        else
                        {
                            resultString += NumericToRomanMapping.D;
                            for (int i = 6; i <= number; i++)
                            {
                                resultString += NumericToRomanMapping.C;
                            }
                        }
                    }
                    else
                    {
                        if (number == 4)
                        {
                            resultString += NumericToRomanMapping.C;
                            resultString += NumericToRomanMapping.D;
                        }
                        else
                        {
                            for (int i = 1; i <= number; i++)
                            {
                                resultString += NumericToRomanMapping.C;
                            }
                        }
                    }

                    number = Convert.ToInt16(integerNumbers[1].ToString());
                    if (number == 0)
                    {
                        // Do nothing.
                    }
                    else if (number == 5)
                    {
                        resultString += NumericToRomanMapping.L;
                    }
                    else if (number > 5)
                    {
                        if (number == 9)
                        {
                            resultString += NumericToRomanMapping.X;
                            resultString += NumericToRomanMapping.C;
                        }
                        else
                        {
                            resultString += NumericToRomanMapping.L;
                            for (int i = 6; i <= number; i++)
                            {
                                resultString += NumericToRomanMapping.X;
                            }
                        }
                    }
                    else
                    {
                        if (number == 4)
                        {
                            resultString += NumericToRomanMapping.X;
                            resultString += NumericToRomanMapping.L;
                        }
                        else
                        {
                            for (int i = 1; i <= number; i++)
                            {
                                resultString += NumericToRomanMapping.X;
                            }
                        }
                    }

                    number = Convert.ToInt16(integerNumbers[2].ToString());
                    if (number == 0)
                    {
                        // Do nothing.
                    }
                    else if (number == 5)
                    {
                        resultString += NumericToRomanMapping.V;
                    }
                    else if (number > 5)
                    {
                        if (number == 9)
                        {
                            resultString += NumericToRomanMapping.I;
                            resultString += NumericToRomanMapping.X;
                        }
                        else
                        {
                            resultString += NumericToRomanMapping.V;
                            for (int i = 6; i <= number; i++)
                            {
                                resultString += NumericToRomanMapping.I;
                            }
                        }
                    }
                    else
                    {
                        if (number == 4)
                        {
                            resultString += NumericToRomanMapping.I;
                            resultString += NumericToRomanMapping.V;
                        }
                        else
                        {
                            for (int i = 1; i <= number; i++)
                            {
                                resultString += NumericToRomanMapping.I;
                            }
                        }
                    }
                    break;

                case 2:
                    number = Convert.ToInt16(integerNumbers[0].ToString());
                    if (number == 0)
                    {
                        // Do nothing.
                    }
                    else if (number == 5)
                    {
                        resultString += NumericToRomanMapping.L;
                    }
                    else if (number > 5)
                    {
                        if (number == 9)
                        {
                            resultString += NumericToRomanMapping.X;
                            resultString += NumericToRomanMapping.C;
                        }
                        else
                        {
                            resultString += NumericToRomanMapping.L;
                            for (int i = 6; i <= number; i++)
                            {
                                resultString += NumericToRomanMapping.X;
                            }
                        }
                    }
                    else
                    {
                        if (number == 4)
                        {
                            resultString += NumericToRomanMapping.X;
                            resultString += NumericToRomanMapping.L;
                        }
                        else
                        {
                            for (int i = 1; i <= number; i++)
                            {
                                resultString += NumericToRomanMapping.X;
                            }
                        }
                    }

                    number = Convert.ToInt16(integerNumbers[1].ToString());
                    if (number == 0)
                    {
                        // Do nothing.
                    }
                    else if (number == 5)
                    {
                        resultString += NumericToRomanMapping.V;
                    }
                    else if (number > 5)
                    {
                        if (number == 9)
                        {
                            resultString += NumericToRomanMapping.I;
                            resultString += NumericToRomanMapping.X;
                        }
                        else
                        {
                            resultString += NumericToRomanMapping.V;
                            for (int i = 6; i <= number; i++)
                            {
                                resultString += NumericToRomanMapping.I;
                            }
                        }
                    }
                    else
                    {
                        if (number == 4)
                        {
                            resultString += NumericToRomanMapping.I;
                            resultString += NumericToRomanMapping.V;
                        }
                        else
                        {
                            for (int i = 1; i <= number; i++)
                            {
                                resultString += NumericToRomanMapping.I;
                            }
                        }
                    }
                    break;

                case 1:
                    number = Convert.ToInt16(integerNumbers[0].ToString());
                    if (number == 0)
                    {
                        // Do nothing.
                    }
                    else if (number == 5)
                    {
                        resultString += NumericToRomanMapping.V;
                    }
                    else if (number > 5)
                    {
                        if (number == 9)
                        {
                            resultString += NumericToRomanMapping.I;
                            resultString += NumericToRomanMapping.X;
                        }
                        else
                        {
                            resultString += NumericToRomanMapping.V;
                            for (int i = 6; i <= number; i++)
                            {
                                resultString += NumericToRomanMapping.I;
                            }
                        }
                    }
                    else
                    {
                        if (number == 4)
                        {
                            resultString += NumericToRomanMapping.I;
                            resultString += NumericToRomanMapping.V;
                        }
                        else
                        {
                            for (int i = 1; i <= number; i++)
                            {
                                resultString += NumericToRomanMapping.I;
                            }
                        }
                    }
                    break;

                default:
                    break;
            }

            return resultString;
        }

        public int ConvertRomanToNumeric(string romanValue)
        {
            int result = 0;
            var romanNumberals = romanValue.ToCharArray();
            //List<int> numericValues = new List<int>();

            for (int i = 0; i <= romanNumberals.Length - 1; i++)
            {
                int value = (int)Enum.Parse(typeof(NumericToRomanMapping), romanNumberals[i].ToString());
                int nextValue = 0;
                if (i < romanNumberals.Length - 1)
                {
                    nextValue = (int)Enum.Parse(typeof(NumericToRomanMapping), romanNumberals[i+1].ToString());
                }

                if (value < nextValue)
                {
                    result += nextValue - value;
                    i++;
                }
                else
                {
                    result += value;
                }
            }

            return result;
        }
    }

    public enum NumericToRomanMapping
    {
        I = 1,
        V = 5,
        X = 10,
        L = 50,
        C = 100,
        D = 500,
        M = 1000
    }
}
