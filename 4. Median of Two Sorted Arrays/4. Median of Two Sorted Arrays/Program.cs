using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Median_of_Two_Sorted_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 2, 6, 9, 15 };
            int[] nums2 = { 1, 4, 3, 3 };

            Solution s1 = new Solution();

            Console.WriteLine(s1.FindMedianSortedArrays(nums1, nums2));
            
            Console.ReadLine();
        }
    }
}
