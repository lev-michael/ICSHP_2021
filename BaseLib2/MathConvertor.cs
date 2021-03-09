using System;
using System.Collections.Generic;
using System.Text;

namespace BaseLib
{
    public class MathConvertor
    {
        private static Dictionary<char, int> RomanMap = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        private static Dictionary<int, string> IntegerToRomanMap = new Dictionary<int, string>()
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" },
        };

    public static int DecimalToBinary(int val)
        {
            return int.Parse(Convert.ToString(val, 2));
        }

        public static int BinaryToDecimal(string val)
        {
            return Convert.ToInt32(val, 2);
        }

        public static string IntegerToRoman(int value)
        {
            StringBuilder romanNumber = new StringBuilder();
            foreach(var num in IntegerToRomanMap)
            {
                while(value >= num.Key)
                {
                    romanNumber.Append(num.Value);
                    value -= num.Key;
                }
            }
            return romanNumber.ToString();
        }

        public static int RomanToInteger(string romanNumber)
        {
            char previousChar = romanNumber[0];
            int number = 0;
            foreach (var currentChar in romanNumber)
            {
                number += RomanMap[currentChar];
                if (RomanMap[previousChar] < RomanMap[currentChar])
                {
                    number -= RomanMap[previousChar] * 2;
                }
                previousChar = currentChar;
            }
            return number;           
        }
    }
}