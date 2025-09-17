using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1509.Minimum_Difference_Between_Largest_and_Smallest
{
    internal class Solution
    {
        public static int MinDifference(int[] nums)
        {
            int[] sortedArray = nums.OrderBy(n => n).ToArray();
            int medianIndex = sortedArray.Length / 2;
            int median = (medianIndex / 2) % 2 == 0 ? (int)(Math.Floor((double)sortedArray[medianIndex]) + Math.Ceiling((double)sortedArray[medianIndex])) / 2 : sortedArray[medianIndex];

            for (int i = 3; i > 0; i--)
            {

                if (Math.Abs(median - sortedArray[0]) < Math.Abs(median - sortedArray[sortedArray.Length - 1]))
                {
                    median = sortedArray[0];
                }
                else if (Math.Abs(median - sortedArray[0]) == Math.Abs(median - sortedArray[sortedArray.Length - 1]))
                {
                    median = median; // no change
                }
                else
                {
                    median = sortedArray[sortedArray.Length - 1];
                }

                if (Math.Abs(median - sortedArray[0]) >= Math.Abs(median - sortedArray[sortedArray.Length - 1]))
                {
                    sortedArray[0] = median;
                }
                else
                {
                    sortedArray[sortedArray.Length - 1] = median;
                }

                sortedArray = sortedArray.OrderBy(n => n).ToArray();
                median = (medianIndex / 2) % 2 == 0 ? (int)(Math.Floor((double)sortedArray[medianIndex]) + Math.Ceiling((double)sortedArray[medianIndex])) / 2 : sortedArray[medianIndex];
            }

            foreach (var num in sortedArray)
            {
                Console.Write(num + " ");
            }

            return sortedArray[sortedArray.Length - 1] - sortedArray[0];
        }
    }
}
