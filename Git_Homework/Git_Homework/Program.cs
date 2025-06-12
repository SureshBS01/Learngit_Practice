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

    }
}
