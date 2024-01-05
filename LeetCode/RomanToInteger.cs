using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            // Map Char -> number
            int sum = 0;
            Dictionary<char, int> values = new Dictionary<char, int>() {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

            for (int i = 0; i < s.Length; i++)
            {
                if (i == s.Length - 1)
                {
                    sum += values[s[i]];
                }
                else if (values[s[i]] < values[s[i + 1]])
                {
                    sum += values[s[i + 1]] - values[s[i]];
                    i++;
                }
                else
                {
                    sum += values[s[i]];
                }
            }
            return sum;

        }
    }
}
