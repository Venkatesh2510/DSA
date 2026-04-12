// 347. Top K Frequent Elements

// Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.

 

// Example 1:

// Input: nums = [1,1,1,2,2,3], k = 2

// Output: [1,2]

// Example 2:

// Input: nums = [1], k = 1

// Output: [1]

// Example 3:

// Input: nums = [1,2,1,2,1,2,3,1,3,2], k = 2

// Output: [1,2]

 

// Constraints:

// 1 <= nums.length <= 105
// -104 <= nums[i] <= 104
// k is in the range [1, the number of unique elements in the array].
// It is guaranteed that the answer is unique.
 

// Follow up: Your algorithm's time complexity must be better than O(n log n), where n is the array's size.

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var d=new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            if(!d.ContainsKey(nums[i]))
            {
                d[nums[i]]=1;
            }
            else{
                d[nums[i]]++;
            }
        }
        var pq=new PriorityQueue<int,int>(Comparer<int>.Create((a,b) => b.CompareTo(a)));
        foreach(var kv in d)
        {
            pq.Enqueue(kv.Key, kv.Value);
        }
        int[] ans = new int[k];
        int j=0;
        while(k>0)
        {
            ans[j]=pq.Dequeue();
            k--;
            j++;
        }
        return ans;
    }
}
