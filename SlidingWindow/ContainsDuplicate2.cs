// Contains Duplicate II
// Solved
// Easy
// Topics
// Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.

 

// Example 1:

// Input: nums = [1,2,3,1], k = 3
// Output: true
// Example 2:

// Input: nums = [1,0,1,1], k = 1
// Output: true
// Example 3:

// Input: nums = [1,2,3,1,2,3], k = 2
// Output: false


public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
       HashSet<int> h = new HashSet<int>();
       int c=0;
       for(int i=0;i<nums.Length;i++)
       {
            if(h.Contains(nums[i]))
            {
                return true;
            }
            h.Add(nums[i]);
            if(h.Count>k)
            {
                h.Remove(nums[i-k]);
            }
            
       }
       return false;
    }
}
