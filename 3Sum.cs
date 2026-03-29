public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> list = new List<IList<int>>();
        Array.Sort(nums);
        for(int i=0;i<nums.Length-2;i++)
        {
            if(i>0&&nums[i]==nums[i-1])
            {
                continue;
            }
            int l=i+1;
            int r=nums.Length-1;
            while(l<r)
            {
                int sum=nums[l]+nums[r]+nums[i];
                if(sum==0)
                {
                    list.Add(new List<int>{nums[l], nums[r], nums[i]});
                    while(l<r&&nums[l]==nums[l+1])
                    {
                        l++;
                    }
                    while(l<r&&nums[r]==nums[r-1])
                    {
                        r--;
                    }
                    l++;
                    r--;
                }
                else if(sum<0)
                {
                    l++;
                }
                else{
                    r--;
                }
            }
        }
        return list;
    }
}