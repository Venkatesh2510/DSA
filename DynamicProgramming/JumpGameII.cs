// 45. Jump Game II

// You are given a 0-indexed array of integers nums of length n. You are initially positioned at index 0.

// Each element nums[i] represents the maximum length of a forward jump from index i. In other words, if you are at index i, you can jump to any index (i + j) where:

// 0 <= j <= nums[i] and
// i + j < n
// Return the minimum number of jumps to reach index n - 1. The test cases are generated such that you can reach index n - 1.

 

// Example 1:

// Input: nums = [2,3,1,1,4]
// Output: 2
// Explanation: The minimum number of jumps to reach the last index is 2. Jump 1 step from index 0 to 1, then 3 steps to the last index.
// Example 2:

// Input: nums = [2,3,0,1,4]
// Output: 2
 

// Constraints:

// 1 <= nums.length <= 104
// 0 <= nums[i] <= 1000
// It's guaranteed that you can reach nums[n - 1].

public class Solution {
    int[] dp = new int[1000005];
    public int Jump(int[] nums) {
        // Array.Fill(dp, -1);
        // return rec(nums,0);
        int jump=0, farthest=0, currentEnd=0;
        for(int i=0;i<nums.Length-1;i++)
        {
            farthest=Math.Max(farthest, i+nums[i]);
            if(currentEnd==i)
            {
                jump++;
                currentEnd=farthest;
            }
        }
        return jump;
    }
    int rec(int[] nums, int i)
    {
        if(i>=nums.Length-1)
        {
            return 0;
        }
        if(dp[i]!=-1)
        {
            return dp[i];
        }
        int mini=int.MaxValue;
        for(int j=i+1;j<=Math.Min(i+nums[i],nums.Length-1);j++)
        {
            int res=Math.Min(mini,rec(nums, j));
            if(res!=int.MaxValue)
            {
                mini=Math.Min(mini, res+1);
            }
        }
        return dp[i]=mini;
    }
}
