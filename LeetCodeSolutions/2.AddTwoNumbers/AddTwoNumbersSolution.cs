using System.Collections.Generic;

namespace LeetCodeSolutions._2.AddTwoNumbers
{
    public class AddTwoNumbersSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            int left = 0;
            var values = new List<int>();

            while (l1 != null || l2 != null || left != 0)
            {
                var currentValue = (l1?.val ?? 0) + (l2?.val ?? 0) + left;

                if (currentValue > 9)
                {
                    left = 1;
                    currentValue = currentValue - 10;
                }
                else
                {
                    left = 0;
                }

                values.Add(currentValue);

                l1 = l1?.next;
                l2 = l2?.next;
            }

            ListNode l3 = null;

            for (int i = values.Count - 1; i >= 0; i--)
            {
                l3 = new ListNode(values[i], l3);
            }

            return l3;
        }
    }
}
