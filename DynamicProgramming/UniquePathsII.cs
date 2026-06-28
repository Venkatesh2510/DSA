63. Unique Paths II

You are given an m x n integer array grid. There is a robot initially located at the top-left corner (i.e., grid[0][0]). The robot tries to move to the bottom-right corner (i.e., grid[m - 1][n - 1]). The robot can only move either down or right at any point in time.

An obstacle and space are marked as 1 or 0 respectively in grid. A path that the robot takes cannot include any square that is an obstacle.

Return the number of possible unique paths that the robot can take to reach the bottom-right corner.

The testcases are generated so that the answer will be less than or equal to 2 * 109.

 

Example 1:


Input: obstacleGrid = [[0,0,0],[0,1,0],[0,0,0]]
Output: 2
Explanation: There is one obstacle in the middle of the 3x3 grid above.
There are two ways to reach the bottom-right corner:
1. Right -> Right -> Down -> Down
2. Down -> Down -> Right -> Right
Example 2:


Input: obstacleGrid = [[0,1],[0,0]]
Output: 1
 

Constraints:

m == obstacleGrid.length
n == obstacleGrid[i].length
1 <= m, n <= 100
obstacleGrid[i][j] is 0 or 1.


public class Solution {
    int[,] dp;
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        int tx=obstacleGrid.Length-1;
        int ty=obstacleGrid[0].Length-1;
        dp=new int[tx+1,ty+1];
        if (obstacleGrid[0][0] == 1 || obstacleGrid[tx][ty] == 1)
            return 0;
        for(int i=0;i<=tx;i++)
        {
            for(int j=0;j<=ty;j++)
            {
                dp[i,j]=-1;
            }
        }
        paths(obstacleGrid, 0, 0, tx, ty, dp);
        return dp[0,0];
    }
    public int paths(int[][] obstacleGrid, int i, int j, int tx, int ty, int[,] dp)
    {
        if(i==tx&&j==ty)
        {
            return dp[i,j]=1;
        }
        if(dp[i,j]!=-1)
        {
            return dp[i,j];
        }
        int ans=0;
        if(valid(i+1, j, tx, ty, obstacleGrid))
        {
            ans+=paths(obstacleGrid, i+1, j, tx, ty, dp);
        }
        if(valid(i, j+1, tx, ty, obstacleGrid))
        {
            ans+=paths(obstacleGrid, i, j+1, tx, ty, dp);
        }
        return dp[i,j]=ans;
    }
    bool valid(int i, int j, int tx, int ty, int[][] obstacleGrid)
    {
        if(i<0||i>tx||j<0||j>ty||obstacleGrid[i][j]==1)
        {
            return false;
        }
        return true;
    }
}
