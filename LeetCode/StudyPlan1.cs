using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class StudyPlan1
    {
        /*
         *  Day 1 Problems
         */
        public int[] RunningSum(int[] nums)
        {
            int[] ans = new int[nums.Length];

            ans[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                ans[i] = nums[i] + ans[i - 1];
            }

            return ans;
        }


        public int PivotIndex(int[] nums)
        {
            int sum = 0;
            int leftSum = 0;

            // Get Sum
            foreach (int a in nums)
            {
                sum = sum + a;
            }

            // Find pivot
            // pivot is where left sum = sum - i - leftSum
            for (int i = 0; i < nums.Length; i++)
            {

                if (leftSum == sum - nums[i] - leftSum)
                {
                    return i;
                }

                leftSum += nums[i];

            }
            return -1;

        }

        /*
         *  Day 2 Problems
         */
        public bool IsIsomorphic(string s, string t)
        {


            // SLOW and NOT GREAT BOB

            // 2944ms, faster than 5.04%
            // 42.5mb, less than 5.04%

            // Fix by removing double Dicts
            //      check if key exists
            //      check if value exists
            //      check if they are expected
            //      any fail, return false
            //      else true

            Dictionary<char, char> mapXY = new Dictionary<char, char>();
            Dictionary<char, char> mapYX = new Dictionary<char, char>();
            char[] x = s.ToCharArray();
            char[] y = t.ToCharArray();

            for (int i = 0; i < x.Length; i++)
            {
                // try to map letters - X TO Y
                try
                {
                    mapXY.Add(x[i], y[i]);
                    mapYX.Add(y[i], x[i]);
                }
                // try to add a character that is already mapped
                catch (Exception ex)
                {
                    if (mapXY[x[i]] != y[i] || mapYX[y[i]] != x[i])
                        return false;
                }
            }
            // Nothing triggered a false
            return true;
        }

        public bool IsSubsequence(string s, string t)
        {
            int count = 0;
            if (s.Length == 0)
                return true;

            for (int i = 0; i < t.Length && count < s.Length; i++)
            {

                if (t[i] == s[count])
                    count++;

            }

            return count == s.Length;
        }

    }
}
