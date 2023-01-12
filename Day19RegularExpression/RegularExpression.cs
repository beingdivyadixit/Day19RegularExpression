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
        //Created first Name method-UC1
        public static void fisrtName()
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            string[] arr = { "Divya" };
            TestPattern(pattern, arr);
        }
        //Created last Name method-UC2
        public static void lastName()
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            string[] arr = { "Dixit" };
            TestPattern(pattern, arr);
        }
        //Created email method-UC3
        public static void email()
        {
            string pattern = "^[a-z]{3}.[a-z]{2,}@[a-z]{2}.[a-z]{2}.[a-z]{2}$";
            string[] arr = { "abc.xyz@bl.co.in" };
            TestPattern(pattern, arr);
        }
        //Created phone number method
        public static void phoneNumber()
        {
            string pattern = "^[0-9]{2}[ ][0-9]{10}$";
            string[] arr = { "91 9919819801" };
            TestPattern(pattern, arr);
        }
        //Created password method
        public static void password()
        {
            string pattern = "^[A-Z]{1}[a-z]{7,}$";
            string[] arr = { "Abcdefgh", "Kjhfgdhs" };
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
