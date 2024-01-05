using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution
    {
        public bool RotateString(string s, string goal)
        {
            if (s.Length != goal.Length)
            {
                return false;
            }
            return (s + s).Contains(goal);

        }
    }
}
