// 77. Combinations

// Given two integers n and k, return all possible combinations of k numbers chosen from the range [1, n].

// You may return the answer in any order.

 

// Example 1:

// Input: n = 4, k = 2
// Output: [[1,2],[1,3],[1,4],[2,3],[2,4],[3,4]]
// Explanation: There are 4 choose 2 = 6 total combinations.
// Note that combinations are unordered, i.e., [1,2] and [2,1] are considered to be the same combination.
// Example 2:

// Input: n = 1, k = 1
// Output: [[1]]
// Explanation: There is 1 choose 1 = 1 total combination.
 

// Constraints:

// 1 <= n <= 20
// 1 <= k <= n

public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        IList<IList<int>> ans=new List<IList<int>>();
        List<int> list = new List<int>();
        helper(ans, 1, n, k, list);
        return ans;
    }
    public void helper(IList<IList<int>> ans, int idx, int n, int k, List<int> list)
    {
        if(list.Count == k)
        {
            ans.Add(new List<int>(list));
            return;
        }
        for(int i=idx;i<=n;i++)
        {
            list.Add(i);
            helper(ans, i+1, n, k,list);
            list.RemoveAt(list.Count - 1);

        }
        return;
    }
}
