using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Welcome to git learning!");

            Console.WriteLine("Check Palindrome ");

            Console.Write("Enter a word: ");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine($"'{input}' is a palindrome!");
            }
            else
            {
                Console.WriteLine($"'{input}' is not a palindrome.");
            }

           Console.Write("Enter a year to check if it's a leap year: ");
            string leapYearInput = Console.ReadLine();

            if (int.TryParse(leapYearInput, out int year))
            {
                if (IsLeapYear(year))
                {
                    Console.WriteLine($"{year} is a leap year.");
                }
                else
                {
                    Console.WriteLine($"{year} is not a leap year.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric year.");
            }

            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();

            Console.WriteLine("Is Prime or Not");

            Console.Write("Enter a number: ");
            string number = Console.ReadLine();

            if (IsPrimeorNot(number))
            {
                Console.Write("Number is Prime.");
            }
            else
            {
                Console.Write("Number is not Prime.");
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }



        static bool IsPalindrome(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            string cleaned = input.ToLower().Replace(" ", "");

            int left = 0;
            int right = cleaned.Length - 1;

            while (left < right)
            {
                if (cleaned[left] != cleaned[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }

        static List<int> GenerateFibonnacciSeries()
        {
            List<int> fibNumbers = new List<int>();
            return fibNumbers;
        }

        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        static bool IsPrimeorNot(string number)
        {
            int number1 = Convert.ToInt32(number);
            bool IsPrime = true;
            for (int i = 2; i < number1 / 2; i++)
            {
                if (number1 % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            return IsPrime;


        }

    }
}
