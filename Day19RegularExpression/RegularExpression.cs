using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19RegularExpression
{
    internal class RegularExpression
    {
        //Created first Name method
        public static void fisrtName()
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            string[] arr = { "Divya" };
            TestPattern(pattern, arr);
        }
        //Created Test pattern method
        public static void TestPattern(string pattern, string[] arr)
        {
            foreach (string inputs in arr)
            {
                if (Regex.IsMatch(inputs, pattern))
                {
                    Console.WriteLine("{0} is valid", inputs);
                }
                else
                {
                    Console.WriteLine("{0} is invalid", inputs);
                }
            }
        }
    }
}
