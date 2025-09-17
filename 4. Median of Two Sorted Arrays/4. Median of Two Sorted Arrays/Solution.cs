using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Median_of_Two_Sorted_Arrays
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int n1  = nums1.Length;
            int n2 = nums2.Length;

            if ((n1 + n2) % 2 == 0)
            {
                double median = 0;
                double m1index = Math.Floor(((double)n1 + (double)n2) / 2) - 1;
                double m2index = m1index + 1;

                int m = 0;
                int n = 0;

                for (int i = 0; i <= m2index; i++)
                {
                    if (nums1[m] < nums2[n])
                    {
                        if (i == m1index || i == m2index)
                        {
                            median += nums1[m];
                        }
                        m++;
                    }
                    else
                    {

                        if (i == m1index || i == m2index)
                        {
                            median += nums2[n];
                        }
                        n++;
                    }
                }

                return median / 2;
            }
            else
            {
                return 0.1;
            }
            
        }
    }
}
