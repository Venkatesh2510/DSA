# 257. Binary Tree Paths

# Given the root of a binary tree, return all root-to-leaf paths in any order.

# A leaf is a node with no children.

 

# Example 1:


# Input: root = [1,2,3,null,5]
# Output: ["1->2->5","1->3"]
# Example 2:

# Input: root = [1]
# Output: ["1"]
 

# Constraints:

# The number of nodes in the tree is in the range [1, 100].
# -100 <= Node.val <= 100

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
    List<string> ans;
    public IList<string> BinaryTreePaths(TreeNode root) {
        ans=new List<string>();
        List<string> s=new List<string>();
        helper(root,s);
        return ans;
    }
    public void helper(TreeNode r, List<string> s)
    {
        if(r.left==null&&r.right==null)
        {
            s.Add(r.val.ToString());
            ans.Add(string.Join("",s));
            s.RemoveAt(s.Count - 1);
            return;
        }
        else{
            if(r.left!=null)
            {
                s.Add(r.val.ToString()+"->");
                helper(r.left,s);
                s.RemoveAt(s.Count - 1);
            }
            if(r.right!=null)
            {
                s.Add(r.val.ToString()+"->");
                helper(r.right,s);
                s.RemoveAt(s.Count - 1);
            }
        }
        return;
    }
}
