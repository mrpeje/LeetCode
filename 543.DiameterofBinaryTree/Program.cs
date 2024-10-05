
var right1 = new TreeNode(3, null, null);
var right2 = new TreeNode(5, null, null);
var left2 = new TreeNode(4, null, null);
var left1 = new TreeNode(2, left2, right2);
var root = new TreeNode(1, left1, right1);


var sol = new Solution();
sol.DiameterOfBinaryTree(root);
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    List<int> List = new List<int>();
    public int DiameterOfBinaryTree(TreeNode root)
    {
        
        List<TreeNode> nodeList = new List<TreeNode>();
        nodeList.Add(root);
        while (nodeList.Count > 0)
        {
            var node = nodeList[0];
            if (node.left != null) 
                nodeList.Add(node.left);            
            if(node.right != null) 
                nodeList.Add(node.right);
            nodeList.RemoveAt(0);
            List.Add(maxDepth(node));
        }
        return List.MaxBy(x => x);
    }
    private int maxDepth(TreeNode node)
    {
        
        var leftTreeDepth = NodeMaxDepth(node.left, 1);
        var rightTreeDepth = NodeMaxDepth(node.right, 1);
        return leftTreeDepth + rightTreeDepth;
    }
    private int NodeMaxDepth(TreeNode node, int currentCount)
    {
        if(node == null)
            return 0;
        int i = currentCount;
        int j = currentCount;
        if (node.left != null)
        {
            int depth = currentCount + 1;
            i = NodeMaxDepth(node.left, depth);
        }
        if (node.right != null)
        {
            int depth = currentCount + 1;
            j = NodeMaxDepth(node.right, depth);
        }
        if (i > j)
            return i;
        else
            return j;
    }
}