using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Palindrome_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(-121));
        }

        static public bool IsPalindrome(int x)
        {
            bool result = true;
            string s1 = x.ToString();

            for (int i = 0, j=s1.Length-1; i<(s1.Length/2) + s1.Length%2; i++, j--)
            {
                if (s1[i] != s1[j])
                {
                    result = false; 
                    break;
                }
            }

            return result;
        }
    }
}
