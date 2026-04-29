// 62. Unique Paths

// There is a robot on an m x n grid. The robot is initially located at the top-left corner (i.e., grid[0][0]). The robot tries to move to the bottom-right corner (i.e., grid[m - 1][n - 1]). The robot can only move either down or right at any point in time.

// Given the two integers m and n, return the number of possible unique paths that the robot can take to reach the bottom-right corner.

// The test cases are generated so that the answer will be less than or equal to 2 * 109.

 

// Example 1:


// Input: m = 3, n = 7
// Output: 28
// Example 2:

// Input: m = 3, n = 2
// Output: 3
// Explanation: From the top-left corner, there are a total of 3 ways to reach the bottom-right corner:
// 1. Right -> Down -> Down
// 2. Down -> Down -> Right
// 3. Down -> Right -> Down
 

// Constraints:

// 1 <= m, n <= 100

public class Solution {
    private static readonly (int dx, int dy)[] directions = new (int, int)[]
    {
        (0,1), (1,0)
    };   
    public bool validMove(int i, int j, int m, int n)
    {
        if(i<0||i>m||j<0||j>n)
        {
            return false;
        }
        return true;
    }
    public int UniquePaths(int m, int n) {
        int[][] dp = new int[m][];
        for(int i=0;i<m;i++)
        {
            dp[i] = new int[n];
            Array.Fill(dp[i],-1);
        }
        return helper(0,0,m-1,n-1,dp);
    }
    int helper(int i, int j, int m, int n, int[][] dp)
    {
        if(i==m&&j==n)
        {
            return 1;
        }
        int ans=0;
        if(dp[i][j]!=-1)
        {
            return dp[i][j];
        }
        foreach(var (dx,dy) in directions)
        {
            if(validMove(i+dx, j+dy,m,n))
            {
                ans+=helper(i+dx,j+dy,m,n,dp);
            }
        }
        return dp[i][j]=ans;

    }
}
