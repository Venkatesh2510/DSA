public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        int diff=int.MaxValue;
        int ans=0;
        Array.Sort(nums);
        for(int i=0;i<nums.Length-2;i++)
        {
            int l=i+1;
            int r=nums.Length-1;
            while(l<r)
            {
                int sum=nums[i]+nums[l]+nums[r];
                if(Math.Abs(target-sum)<diff)
                {
                    diff=Math.Abs(target-sum);
                    ans=sum;
                }
                if(sum<target)
                {
                    l++;
                }
                else{
                    r--;
                }
            }
        }
        return ans;
    }
}