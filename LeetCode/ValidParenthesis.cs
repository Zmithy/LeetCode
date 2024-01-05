using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            Stack stack = new Stack();
            char[] chars = s.ToCharArray();

            foreach (char c in chars)

                if (c == '{')
                    stack.Push('}');
                else if (c == '(')
                    stack.Push(')');
                else if (c == '[')
                    stack.Push(']');

                else
                {
                    if (stack.Count == 0)
                        return false;
                    if ((char)stack.Pop() != c)
                        return false;
                }
            return stack.Count == 0;
            // return if stack is empty
        }
    }
}
