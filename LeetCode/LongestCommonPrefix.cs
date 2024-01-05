using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {

            // NUll || 0 Length array 
            if (strs == null || strs.Length == 0)
            {
                return "";
            }

            // Using Binary Search approach
            var lcp = strs[0];
            var low = 1;
            var high = lcp.Length;


            // Conduct search
            while (low <= high)
            {
                var mid = (low + high) / 2;
                if (Common(strs, mid))
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return strs[0].Substring(0, (low + high) / 2);

        }
        // Returns false if the substring is not found
        // 
        public bool Common(string[] strs, int l)
        {
            var str = strs[0].Substring(0, l);
            for (int i = 0; i < strs.Length; i++)
            {
                if (!strs[i].StartsWith(str))
                    return false;
            }
            return true;
        }
    }
}
