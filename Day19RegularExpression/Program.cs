using System;

namespace Day19RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome To Regular Expression programs ");
            Console.WriteLine("Enter-\n1:Create first name\n2:Create last name\n3:Create valid Email ID\n4:Create phone number with country code\n5:Create Passward Rule-1\n6:Create Passward Rule-2\n7:Create Passward Rule-3\n8:Create Passward Rule-4");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    //UC-1
                    RegularExpression.fisrtName();
                    break;
                case 2:
                    //UC-2
                    RegularExpression.lastName();
                    break;
                case 3:
                    //UC-3
                    RegularExpression.email();
                    break;
                case 4:
                    //UC-4
                    RegularExpression.phoneNumber();
                    break;
                case 5:
                    //UC-5
                    RegularExpression.password();
                    break;
                case 6:
                    //UC-6
                    RegularExpression.password();
                    break;
                case 7:
                    //UC-7
                    RegularExpression.password();
                    break;
                case 8:
                    //UC-8
                    RegularExpression.password();
                    break;
                default:
                    break;
            }
        }
    }
}
