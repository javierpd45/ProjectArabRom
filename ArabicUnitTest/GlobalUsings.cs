global using NUnit.Framework;

namespace ArabicUnitTest
{
    public class ConversorNum
    {
        private readonly Dictionary<int, string> numbersAR = new Dictionary<int, string>()
        {
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {400, "CD"},
            {100, "C"},
            {90, "XC"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"}
        };

        public string ConvertArabicRoman(int num)
        {
            if (num < 1 || num > 3999)
            {
                throw new ArgumentOutOfRangeException("La entrada no es valida.\nDebe ser un numero entero entre 1 y 3,999.");
            }

            string result = string.Empty;

            foreach (var item in numbersAR)
            {
                while (num >= item.Key)
                {
                    result = result + item.Value;
                    num = num - item.Key;
                }
            }

            return result;
        }
    }
}