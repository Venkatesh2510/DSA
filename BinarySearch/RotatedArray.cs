// Search in Rotated Sorted Array

// There is an integer array nums sorted in ascending order (with distinct values).

// Prior to being passed to your function, nums is possibly left rotated at an unknown index k (1 <= k < nums.length) such that the resulting array is [nums[k], nums[k+1], ..., nums[n-1], nums[0], nums[1], ..., nums[k-1]] (0-indexed). For example, [0,1,2,4,5,6,7] might be left rotated by 3 indices and become [4,5,6,7,0,1,2].

// Given the array nums after the possible rotation and an integer target, return the index of target if it is in nums, or -1 if it is not in nums.

// You must write an algorithm with O(log n) runtime complexity.

public class Solution {
    public int Search(int[] nums, int target) {
        int p=pivot(nums);
        int a=bin(nums,0,p,target);
        int b=bin(nums,p+1, nums.Length-1, target);
        if(a!=-1)
        {
            return a;
        }
        if(b!=-1)
        {
            return b;
        }
        return -1;
    }
    int bin(int[] nums, int l, int r, int target)
    {
        
        while(l<=r)
        {
            int mid=l+(r-l)/2;
            if(nums[mid]==target)
            {
                return mid;
            }else if(nums[mid]<target)
            {
                l=mid+1;
            }else{
                r=mid-1;
            }
        }
        return -1;
    }
    int pivot(int[] nums)
    {
        int l=0, r=nums.Length-1;
        int a=0,b=0,c=0;
        while(l<=r)
        {
            int mid=l+(r-l)/2;
            if(mid<r&&nums[mid]>nums[mid+1])
            {
                return mid;
            }
            if(mid>l&&nums[mid-1]>nums[mid])
            {
                return mid-1;
            }
            if(nums[l]<=nums[mid])
            {
                l=mid+1;
            }else{
                r=mid-1;
            }
        }
        return nums.Length-1;
    }
}
