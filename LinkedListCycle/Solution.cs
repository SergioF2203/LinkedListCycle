using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListCycle
{
    class Solution
    {
        public static bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null) return false;

            var hashTableNodes = new HashSet<ListNode>();
            hashTableNodes.Add(head);

            var nextNode = head.next;
            while (true)
            {
                hashTableNodes.Add(nextNode);
                if (nextNode.next != null)
                    nextNode = nextNode.next;
                else return false;
                if (hashTableNodes.Contains(nextNode)) return true;
                if (nextNode.next == head) return true;
            }
        }
    }
}
