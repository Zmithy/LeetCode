using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution
    {
        public int IntegerReplacement(int n)
        {
            int count = 0;
            if (n == Int32.MaxValue)
            {
                n -= 1;
            }
            while (n != 1)
            {
                if (n % 2 == 0)
                    n = n / 2;
                else if (n == 3)
                    return count + 2;
                else
                {
                    if (n % 4 == 3)
                        n += 1;
                    else
                        n -= 1;

                }
                count++;
            }
            return count;
        }
    }
}
