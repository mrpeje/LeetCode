// O(n)
public class ListNode 
{
    public int val;
    public ListNode next;
    public ListNode(int x) {
        val = x;
        next = null;
    }
}

public class Solution
{
    public bool HasCycle(ListNode head)
    {
        ListNode slowPtr = head;
        ListNode fastPtr = head;
        while (fastPtr != null)
        {
            slowPtr = slowPtr.next;
            fastPtr = fastPtr.next;
            if (slowPtr == null || fastPtr == null)
                return false;
            fastPtr = fastPtr.next;
            if (slowPtr == fastPtr)
                return true;
        }
        return false;
    }
}