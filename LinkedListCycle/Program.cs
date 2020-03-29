using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListCycle
{
    class Program
    {
        static void Main(string[] args)
        {
            var ln1 = new ListNode(3);
            var ln2 = new ListNode(2);
            var ln3 = new ListNode(0);
            var ln4 = new ListNode(-4);
            ln1.next = ln2;
            ln2.next = ln1;
            //ln3.next = ln4;
            //ln4.next = ln2;

            Solution.HasCycle(ln1);
        }
    }
}
