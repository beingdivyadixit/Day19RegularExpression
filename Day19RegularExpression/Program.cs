using System;

namespace Day19RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome To Regular Expression programs ");
            Console.WriteLine("Enter-\n1:Create first name\n2:Create last name");
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
                default:
                    break;
            }
        }
    }
}
