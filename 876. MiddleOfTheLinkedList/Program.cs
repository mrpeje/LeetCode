// O(n)
var node4 = new ListNode(5, null);
var node3 = new ListNode(4, node4);
var node2 = new ListNode(3, node3);
var node1 = new ListNode(2, node2);
var head = new ListNode(1, node1);

var sol = new Solution();
sol.MiddleNode(head);
public class ListNode 
{
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) 
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;

        while (fast.next != null)
        {
            slow = slow.next;
            if (fast.next != null)
            {
                fast = fast.next;
                if (fast.next != null)
                    fast = fast.next;
            }
        }
        return slow;
    }
}