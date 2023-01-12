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
        //Created phone number method -UC4
        public static void phoneNumber()
        {
            string pattern = "^[0-9]{2}[ ][0-9]{10}$";
            string[] arr = { "91 9919819801" };
            TestPattern(pattern, arr);
        }
        //Created password method-UC5,6,7,8
        public static void password()
        {
            string pattern = "^[A-Z]{1}[a-z]{4,}(@|#|$|&){1}[0-9]{1,}$";
            string[] arr = { "Akcdof@8", "Kjhfld@68" };
            TestPattern(pattern, arr);
        }
        //Created method clear all samples of emails-UC9
        public static void validateEmails()
        {
            string pattern = "^[a-zA-Z]{3}[_,.,+,-]?[a-zA-Z0-9]*@[a-zA-Z0-9]{1,10}.(com|com.au|net|co.in|com.com)$";
            string[] arr = { "abc.xyz@bridgelabz.co.in", "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc_100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com", "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
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
