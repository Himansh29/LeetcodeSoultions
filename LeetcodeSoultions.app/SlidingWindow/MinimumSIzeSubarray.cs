using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSoultions.app.SlidingWindow
{
    public class MinimumSIzeSubarray
    {
        public class Solution
        {
            public static int MinSubArrayLen(int target, int[] nums)
            {
                int i = 0, j = 0, sum = 0, n = nums.Length, minValue = Int32.MaxValue;

                while (j < n) { 
                    sum += nums[j];
                    while (sum >= target) {
                        minValue = Math.Min(minValue, j-i+1);
                        sum -= nums[i++];
                    }
                    j++;
                }
                return minValue == int.MaxValue ? -1 : minValue;
            }

            
        }

        
    }
}
