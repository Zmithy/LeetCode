using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            // Numbers before are not val, after is val
            // Offset moves when non-val number detected
            int offset = 0;

            for (int i = 0; i < nums.Length; i++)
            {

                // If number is not val
                if (nums[i] != val)
                {

                    // overwrite nums[offset] with nums[i]
                    // re-writes the array with non-val numbers
                    nums[offset] = nums[i];
                    offset++;
                }

            }

            return offset;
        }
    }

}
