// 3 Sum Closest

// Given an integer array nums of length n and an integer target, find three integers at distinct indices in nums such that the sum is closest to target.

// Return the sum of the three integers.

// You may assume that each input would have exactly one solution.



// Example 1:

// Input: nums = [-1,2,1,-4], target = 1
// Output: 2
// Explanation: The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).
// Example 2:

// Input: nums = [0,0,0], target = 1
// Output: 0
// Explanation: The sum that is closest to the target is 0. (0 + 0 + 0 = 0).


// Constraints:

// 3 <= nums.length <= 500
// -1000 <= nums[i] <= 1000
// -104 <= target <= 104
public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        int diff = int.MaxValue;
        int ans = 0;
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i++)
        {
            int l = i + 1;
            int r = nums.Length - 1;
            while (l < r)
            {
                int sum = nums[i] + nums[l] + nums[r];
                if (Math.Abs(target - sum) < diff)
                {
                    diff = Math.Abs(target - sum);
                    ans = sum;
                }
                if (sum < target)
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }
        }
        return ans;
    }
}
