// 743. Network Delay Time


// You are given a network of n nodes, labeled from 1 to n. You are also given times, a list of travel times as directed edges times[i] = (ui, vi, wi), where ui is the source node, vi is the target node, and wi is the time it takes for a signal to travel from source to target.

// We will send a signal from a given node k. Return the minimum time it takes for all the n nodes to receive the signal. If it is impossible for all the n nodes to receive the signal, return -1.

 

// Example 1:


// Input: times = [[2,1,1],[2,3,1],[3,4,1]], n = 4, k = 2
// Output: 2
// Example 2:

// Input: times = [[1,2,1]], n = 2, k = 1
// Output: 1
// Example 3:

// Input: times = [[1,2,1]], n = 2, k = 2
// Output: -1
 

// Constraints:

// 1 <= k <= n <= 100
// 1 <= times.length <= 6000
// times[i].length == 3
// 1 <= ui, vi <= n
// ui != vi
// 0 <= wi <= 100
// All the pairs (ui, vi) are unique. (i.e., no multiple edges.)

public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
        var graph = new List<(int,int)>[n+1];
        for(int i=0;i<=n;i++)
        {
            graph[i]=new List<(int, int)>();
        }
        foreach(var t in times)
        {       
            int u=t[0];
            int v=t[1];
            int s=t[2];
            graph[u].Add((v, s));
        }
        var dist = new int[n+1];
        Array.Fill(dist, int.MaxValue);
        dist[k]=0;
        var pq = new PriorityQueue<(int node, int time), int>();
        pq.Enqueue((k,0), 0);
        while(pq.Count>0)
        {
            var (nd,t) = pq.Dequeue();
            foreach(var (neighbour, weight) in graph[nd])
            {
                if(weight+t<dist[neighbour])
                {
                    dist[neighbour]=weight+t;
                    pq.Enqueue((neighbour, dist[neighbour]), dist[neighbour]);
                }
            }
        }
        int maxi=0;
        for(int i=1;i<=n;i++)
        {
            if(dist[i]==int.MaxValue)
            {
                return -1;
            }
            maxi=Math.Max(maxi, dist[i]);
        }
        return maxi;
    }
}
