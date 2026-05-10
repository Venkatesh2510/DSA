// 102. Binary Tree Level Order Traversal

// Given the root of a binary tree, return the level order traversal of its nodes' values. (i.e., from left to right, level by level).

 

// Example 1:


// Input: root = [3,9,20,null,null,15,7]
// Output: [[3],[9,20],[15,7]]
// Example 2:

// Input: root = [1]
// Output: [[1]]
// Example 3:

// Input: root = []
// Output: []
 

// Constraints:

// The number of nodes in the tree is in the range [0, 2000].
// -1000 <= Node.val <= 1000

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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> ans=new List<IList<int>>();
        Queue<(TreeNode node,int level)> q=new Queue<(TreeNode node,int level)>(); 
        if(root==null)
        {
            return [];
        }
        q.Enqueue((root, 0));
        while(q.Count>0)
        {
            var (node,level) = q.Dequeue();
            if(ans.Count==level)
            {
                ans.Add(new List<int>());
            }
            ans[level].Add(node.val);
            if(node.left!=null)
            {
                q.Enqueue((node.left, level+1));
            }
            if(node.right!=null)
            {
                q.Enqueue((node.right, level+1));
            }
        }
        return ans;
    }
}
