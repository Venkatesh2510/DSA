/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> l=new List<int>();
        inorder(root, l);
        return l;
    }
    public void inorder(TreeNode root, List<int> l)
    {
        if(root==null)
        {
            return;
        }
        inorder(root.left,l);
        l.Add(root.val);
        inorder(root.right,l);
        return;
    }

}
