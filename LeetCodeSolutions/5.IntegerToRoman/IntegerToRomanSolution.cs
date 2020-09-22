using System;
using System.Linq;
using System.Collections.Generic;

namespace LeetCodeSolutions._5.IntegerToRoman
{
    public class IntegerToRomanSolution
    {
        public string IntToRoman(int number)
        {
            var symbols = new List<RomanSymbol>();

            while (number > 0)
            {
                var nextSymbol = FindHighestSymbol(number);
                symbols.Add(nextSymbol);

                number -= (int)nextSymbol;
            }

            return string.Join("", symbols);
        }

        private RomanSymbol FindHighestSymbol(int number)
        {
            var symbols = Enum
                .GetValues(typeof(RomanSymbol))
                .Cast<RomanSymbol>()
                .ToList();

            var highestSymbol = symbols
                .OrderByDescending(s => (int)s)
                .FirstOrDefault(s => (int)s <= number);

            return highestSymbol;
        }

        public enum RomanSymbol
        {
            I = 1,
            IV = 4,
            V = 5,
            IX = 9,
            X = 10,
            XL = 40,
            L = 50,
            XC = 90,
            C = 100,
            CD = 400,
            D = 500,
            CM = 900,
            M = 1000
        }
    }
}
