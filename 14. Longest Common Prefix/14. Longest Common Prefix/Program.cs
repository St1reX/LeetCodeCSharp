using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Longest_Common_Prefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] test = { "flower", "flow", "flight" };
            Console.WriteLine(LongestCommonPrefix(test));
            
        }

        static public string LongestCommonPrefix(string[] strs)
        {
            if(strs.Length == 0) 
            {
                return "";
            }

            string prefix = strs[0];
            
            for (int i = 1; i < strs.Length; i++) 
            {

                if (prefix.Length > strs[i].Length)
                {
                    prefix = prefix.Substring(0, strs[i].Length);
                }


                for(int j = 0; j < strs[i].Length && j<prefix.Length; j++)
                {

                    if (prefix[j] == strs[i][j])
                    {
                        continue;
                    }
                    else
                    {
                        prefix = prefix.Substring(0, j); 
                    }

                }

            }

            return prefix;
        }
    }
}
