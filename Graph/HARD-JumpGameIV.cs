// 1345. Jump Game IV

// Given an array of integers arr, you are initially positioned at the first index of the array.

// In one step you can jump from index i to index:

// i + 1 where: i + 1 < arr.length.
// i - 1 where: i - 1 >= 0.
// j where: arr[i] == arr[j] and i != j.
// Return the minimum number of steps to reach the last index of the array.

// Notice that you can not jump outside of the array at any time.

 

// Example 1:

// Input: arr = [100,-23,-23,404,100,23,23,23,3,404]
// Output: 3
// Explanation: You need three jumps from index 0 --> 4 --> 3 --> 9. Note that index 9 is the last index of the array.
// Example 2:

// Input: arr = [7]
// Output: 0
// Explanation: Start index is the last index. You do not need to jump.
// Example 3:

// Input: arr = [7,6,9,6,9,6,9,7]
// Output: 1
// Explanation: You can jump directly from index 0 to index 7 which is last index of the array.
 

// Constraints:

// 1 <= arr.length <= 5 * 104
// -108 <= arr[i] <= 108

public class Solution {
    public int MinJumps(int[] arr) {
        int n=arr.Length;
        if(n==1)
        {
            return 0;
        }
        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
        for(int i=0;i<n;i++)
        {
            if(!dict.ContainsKey(arr[i]))
            {
                dict[arr[i]] = new List<int>();
            }
            dict[arr[i]].Add(i);
        }
        Queue<int> q = new Queue<int>();
        int[] visited = new int[n];
        for(int i=0;i<n;i++)
        {
            visited[i]=0;
        }
        q.Enqueue(0);
        visited[0]=1;
        int jumps=0;
        while(q.Count>0)
        {
            int size=q.Count;
            for(int i=0;i<size;i++)
            {
                int curr=q.Dequeue();
                if(curr==n-1)
                {
                    return jumps;
                }
                if(curr-1>=0 && visited[curr-1]==0)
                {
                    visited[curr-1]=1;
                    q.Enqueue(curr-1);
                }
                if(curr+1<n && visited[curr+1]==0)
                {
                    visited[curr+1]=1;
                    q.Enqueue(curr+1);
                }
                if(dict.ContainsKey(arr[curr]))
                {
                    for(int j=0;j<dict[arr[curr]].Count;j++)
                    {
                        if(visited[dict[arr[curr]][j]]==0)
                        {
                            visited[dict[arr[curr]][j]]=1;
                            q.Enqueue(dict[arr[curr]][j]);
                        }
                    }
                    dict.Remove(arr[curr]);
                }
            }
            jumps++;
        }
        return -1;
    }
}
