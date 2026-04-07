// 39. Combination Sum

// Given an array of distinct integers candidates and a target integer target, return a list of all unique combinations of candidates where the chosen numbers sum to target. You may return the combinations in any order.

// The same number may be chosen from candidates an unlimited number of times. Two combinations are unique if the frequency of at least one of the chosen numbers is different.

// The test cases are generated such that the number of unique combinations that sum up to target is less than 150 combinations for the given input.

 

// Example 1:

// Input: candidates = [2,3,6,7], target = 7
// Output: [[2,2,3],[7]]
// Explanation:
// 2 and 3 are candidates, and 2 + 2 + 3 = 7. Note that 2 can be used multiple times.
// 7 is a candidate, and 7 = 7.
// These are the only two combinations.
// Example 2:

// Input: candidates = [2,3,5], target = 8
// Output: [[2,2,2,2],[2,3,3],[3,5]]
// Example 3:

// Input: candidates = [2], target = 1
// Output: []
 

// Constraints:

// 1 <= candidates.length <= 30
// 2 <= candidates[i] <= 40
// All elements of candidates are distinct.
// 1 <= target <= 40
 
public class Solution {
    IList<IList<int>> ans;
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        ans=new List<IList<int>>();
        List<int> l=new List<int>();
        helper(candidates, target, 0, l);
        return ans;
    }
    public void helper(int[] cand, int t, int index, List<int> l)
    {
        if(index>=cand.Length)
        {
            return;
        }
        if(t==0)
        {
            ans.Add(new List<int>(l));
            return;
        }
        if(t-cand[index]>=0)
        {
            l.Add(cand[index]);
            helper(cand,t-cand[index], index,l);
            l.RemoveAt(l.Count-1);
        }
        helper(cand, t, index+1, l);
        return;
    }
}
