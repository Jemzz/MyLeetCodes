namespace Leetcodes.LeetSolutions
{
    public class AddTwoNumsListNode
    {
        ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyList = new(0);
            ListNode l3 = dummyList;

            int carry = 0;

            while (l1 != null || l2 != null)
            {
                int l1_val = l1 != null ? l1.val : 0;
                int l2_val = l2 != null ? l2.val : 0;

                int current = l1_val + l2_val + carry;
                carry = current / 10;

                int lastNum = current % 10;

                var newNode = new ListNode(lastNum);
                l3.next = newNode;

                if (l1 != null)
                {
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    l2 = l2.next;
                }

                l3 = l3.next;
            }

            if (carry > 0)
            {
                ListNode dummyListNode = new ListNode(carry);
                l3.next = dummyListNode;
                //l3 = l3.next;
            }

            return dummyList.next;
        }

        public class ListNode(int val = 0, ListNode? next = null)
        {
            public int val = val;
            public ListNode next = next!;
        }
    }
}
