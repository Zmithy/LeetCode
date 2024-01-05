using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            // int to string
            string f = x.ToString();
            string r = reversed(f);


            return f.Equals(r);
        }

        public String reversed(String s)
        {
            // reverse string
            char[] a = s.ToCharArray();
            Array.Reverse(a);
            return new string(a);
        }
    }
}
