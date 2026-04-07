// 47. Permutations II

// Given a collection of numbers, nums, that might contain duplicates, return all possible unique permutations in any order.

 

// Example 1:

// Input: nums = [1,1,2]
// Output:
// [[1,1,2],
//  [1,2,1],
//  [2,1,1]]
// Example 2:

// Input: nums = [1,2,3]
// Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
 

// Constraints:

// 1 <= nums.length <= 8
// -10 <= nums[i] <= 10

public class Solution {
    IList<IList<int>> ans;
    Dictionary<string,int> d;
    public IList<IList<int>> PermuteUnique(int[] nums) {
        ans=new List<IList<int>>();
        d=new Dictionary<string,int>();
        helper(nums, 0);
        return ans;
    }
    public void swap(int[] nums, int i, int j)
    {
        int temp=nums[i];
        nums[i]=nums[j];
        nums[j]=temp;
        return;
    }
    public void helper(int[] nums, int index)
    {
        HashSet<int> h=new HashSet<int>();
        if(index>=nums.Length)
        {  
            ans.Add(new List<int>(nums));
            return;
        }
        for(int i=index;i<nums.Length;i++)
        {
            if(h.Contains(nums[i]))
            {
                continue;
            }
            h.Add(nums[i]);
            swap(nums, index, i);
            helper(nums,index+1);
            swap(nums, index, i);
        }
        return;
    }
}
