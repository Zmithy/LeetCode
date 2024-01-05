using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {

            int size = nums.Length;
            int offset = 0;

            // If element == previous element,
            for (int i = 1; i < size; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    offset++;
                    nums[offset] = nums[i];

                }
            }

            return offset + 1;
        }
    }

}
