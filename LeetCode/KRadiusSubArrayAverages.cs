using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution
    {
        public int[] GetAverages(int[] nums, int k)
        {
            // Answer Array, size of input array.
            // Initialized to all -1
            int[] ans = new int[nums.Length];
            Array.Fill(ans, -1);

            // WINDOW SIZE, 2 * radius + middle value
            var len = 2 * k + 1;

            long sum = 0;


            // 2*Radius + 1 is greater than length of array, return all -1 array
            if (len > nums.Length)
                return ans;

            // MAIN LOOP


            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];


                // i - len is now outside of window, subtract it 
                if (i - len >= 0)
                    sum -= nums[i - len];

                // I > size of window
                if (i >= len - 1)
                    ans[i - k] = (int)(sum / len);
            }
            return ans;
        }
    }
}
