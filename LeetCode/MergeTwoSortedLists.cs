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
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode();
            ListNode head = new ListNode(0, dummy);

            while (list1 != null || list2 != null)
            {

                // If list1 and list2 both exist
                if (list1 != null && list2 != null)
                {
                    if (list1.val < list2.val)
                    {
                        dummy.next = list1;
                        list1 = list1.next;
                        dummy = dummy.next;
                    }
                    else
                    {
                        dummy.next = list2;
                        list2 = list2.next;
                        dummy = dummy.next;
                    }
                }
                // List 1 exists and list 2 does not exist
                else if (list1 != null && list2 == null)
                {
                    dummy.next = list1;
                    list1 = list1.next;
                    dummy = dummy.next;
                }
                // List 2 exists and list1 does not exist
                else
                {
                    dummy.next = list2;
                    list2 = list2.next;
                    dummy = dummy.next;
                }

            }

            return (head.next).next;
        }
    }
}
