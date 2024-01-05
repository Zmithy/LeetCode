using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode(0);
            ListNode current = head;
            int carry = 0;
            int x = 0;
            int y = 0;
            int z = 0;

            while (l1 != null || l2 != null)
            {
                // If l1 is null -> add 0, else add val
                x = (l1 == null) ? 0 : l1.val;

                // If l2 is null -> add 0, else add val
                y = (l2 == null) ? 0 : l2.val;

                // Value to add to new list l1.val + l2.val + carry
                z = x + y + carry;

                // new carry is int division by 10
                carry = z / 10;

                // Get ones digit 
                z = z % 10;


                // Add to list
                current.next = new ListNode(z);


                // Iterate
                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;
                current = current.next;
            }

            if (carry != 0)
            {
                current.next = new ListNode(carry);
            }


            return head.next;
        }
    }
}
