using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            // Guaranteed at least 3 in input
            int closest = nums[0] + nums[1] + nums[nums.Length - 1];
            //int closest = Int32.MaxValue;
            Array.Sort(nums);


            // Iterate Over array

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int j = i + 1;
                int k = nums.Length - 1;

                while (j < k)
                {
                    int sum = nums[i] + nums[j] + nums[k];

                    if (sum == target)
                        return target;
                    else if (sum > target)
                        k--;
                    else
                        j++;


                    if (Math.Abs(sum - target) < Math.Abs(closest - target))
                        closest = sum;
                }
            }

            return closest;

        }
    }
}
