// 547. Number of Provinces

// There are n cities. Some of them are connected, while some are not. If city a is connected directly with city b, and city b is connected directly with city c, then city a is connected indirectly with city c.

// A province is a group of directly or indirectly connected cities and no other cities outside of the group.

// You are given an n x n matrix isConnected where isConnected[i][j] = 1 if the ith city and the jth city are directly connected, and isConnected[i][j] = 0 otherwise.

// Return the total number of provinces.

 

// Example 1:


// Input: isConnected = [[1,1,0],[1,1,0],[0,0,1]]
// Output: 2
// Example 2:


// Input: isConnected = [[1,0,0],[0,1,0],[0,0,1]]
// Output: 3
 

// Constraints:

// 1 <= n <= 200
// n == isConnected.length
// n == isConnected[i].length
// isConnected[i][j] is 1 or 0.
// isConnected[i][i] == 1
// isConnected[i][j] == isConnected[j][i]

public class Solution {
    public int FindCircleNum(int[][] isConnected) {

        int n=isConnected.Length;
        List<int> visited = new List<int>();
        for(int i=0;i<n;i++)
        {
            visited.Add(0);
        } 
        int c=0;
        for(int i=0;i<n;i++)
        {
            if(visited[i]==0)
            {
                c++;
                dfs(visited, isConnected, i);
            }
        }
        return c;
    }
    public void bfs(int[][] isConnected)
    {
        int n=isConnected.Length;
        List<List<int>> graph=new List<List<int>>();
        for(int i=0;i<n;i++)
        {
            graph.Add(new List<int>());
        }
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(i!=j&&isConnected[i][j]==1)
                {
                    graph[i].Add(j);
                }
            }
        }   
        Queue<int> q=new Queue<int>();
        int c=0;
        List<int> visited=new List<int>();
        for(int i=0;i<n;i++)
        {
            visited.Add(0);
        }
        for(int i=0;i<n;i++)
        {
            if(visited[i]==0)
            {
                c++;
                q.Enqueue(i);
                while(q.Count>0)
                {
                    int v=q.Dequeue();
                    foreach(var u in graph[v])
                    {
                        if(visited[u]==0)
                        {
                            q.Enqueue(u);
                            visited[u]=1;
                        }
                    }
                }
            }
        }
        return c;
    }
    public void dfs(List<int> visited,int[][] isConnected, int i)
    {
        visited[i]=1;
        int n=isConnected.Length;
        for(int j=0;j<n;j++)
        {
            if(isConnected[i][j]==1&&visited[j]==0)
            {
                dfs(visited, isConnected, j);
            }
        }
        return;
    }
}
