using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {

            Dictionary<int, int> set = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var key = nums[i];
                var val = i;

                if (set.ContainsKey(target - nums[i]))
                {

                    return new int[] { set[target - nums[i]], i };
                }
                // Handle duplicate keys
                set.TryAdd(key, val);

            }


            int[] none = new int[] { -1, -1 };
            return none;
        }
    }
}
