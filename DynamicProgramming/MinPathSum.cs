<!-- 64. Minimum Path Sum

Given a m x n grid filled with non-negative numbers, find a path from top left to bottom right, which minimizes the sum of all numbers along its path.

Note: You can only move either down or right at any point in time.

 

Example 1:


Input: grid = [[1,3,1],[1,5,1],[4,2,1]]
Output: 7
Explanation: Because the path 1 → 3 → 1 → 1 → 1 minimizes the sum.
Example 2:

Input: grid = [[1,2,3],[4,5,6]]
Output: 12
 

Constraints:

m == grid.length
n == grid[i].length
1 <= m, n <= 200
0 <= grid[i][j] <= 200


public class Solution {
    public int MinPathSum(int[][] grid) {
       int x=grid.Length, y=grid[0].Length;
       int[][] dp = new int[x+1][];
        for(int i=0;i<x;i++)
        {
            dp[i] = new int[y + 1];
            for(int j=0;j<y;j++)
            {
                dp[i][j]=0;
            }
        }
        dp[0][0]=grid[0][0];
        for(int i=1;i<x;i++)
        {
            dp[i][0]=grid[i][0]+dp[i-1][0];
        }
        for(int i=1;i<y;i++)
        {
            dp[0][i]=grid[0][i]+dp[0][i-1];
        }
        for(int i=1;i<x;i++)
        {
            for(int j=1;j<y;j++)
            {
                dp[i][j]=grid[i][j]+Math.Min(dp[i-1][j],dp[i][j-1]);
            }
        }
        return dp[x-1][y-1];
       //return helper(grid, 0,0, dp);
    }
    int helper(int[][] grid, int x, int y, int[][] dp)
    {
        int x2=grid.Length, y2=grid[0].Length;
        if(x<0||x>=x2||y<0||y>=y2)
        {
            return 1000001;
        }
        if(dp[x][y]!=-1)
        {
            return dp[x][y];
        }
        if(x==x2-1&&y==y2-1)
        {
            return grid[x][y];
        }
        int mini=0;
        mini=grid[x][y]+Math.Min(helper(grid, x+1,y,dp), helper(grid, x, y+1,dp));
        return dp[x][y]=mini;
    }
} -->
