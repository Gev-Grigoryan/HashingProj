using System;
using System.Collections.Generic;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "lorem ipsum dolor";
            List<string> strings = new List<string>();
            while (str.Length > 4)
            {
                char[] chars = str.Substring(0, 4).ToCharArray();
                string combined= CharsConvert(chars);
                strings.Add(combined);
                str = str.Substring(4);
            }
            if (str.Length < 4)
            {
                char[] chars = str.ToCharArray();
                string combined = CharsConvert(chars);
                strings.Add(combined);
            }
            decimal result = 0;
            foreach (var item in strings)
            {
                decimal rslt = 0;
                char[] charsArr = item.ToCharArray();
                for (int i = 0; i < charsArr.Length; i++)
                {
                    rslt += Convert.ToInt32(charsArr[i].ToString()) * (decimal)Math.Pow(2, charsArr.Length - i - 1);
                }
                result += rslt;
                Console.WriteLine(rslt);
            }
            Console.WriteLine(result);
        }

        public static string CharsConvert(char[] chars)
        {
            string combined = string.Empty;
            for (int i = 0; i < chars.Length; i++)
            {
                combined = ConvertBinary((int)chars[i]) + combined;
            }
            return combined;
        }

        public static string ConvertBinary(int number)
        {
            if (number == 0) return number.ToString().PadLeft(8, '0');

            string str = string.Empty;
            while (number > 0)
            {
                int num = number % 2;
                str = num.ToString() + str;
                number /= 2;
            }
            return str.PadLeft(8, '0');
        }
    }
}