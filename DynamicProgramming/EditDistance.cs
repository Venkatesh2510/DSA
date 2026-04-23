# <!-- 72. Edit Distance

# Given two strings word1 and word2, return the minimum number of operations required to convert word1 to word2.

# You have the following three operations permitted on a word:

# Insert a character
# Delete a character
# Replace a character
 

# Example 1:

# Input: word1 = "horse", word2 = "ros"
# Output: 3
# Explanation: 
# horse -> rorse (replace 'h' with 'r')
# rorse -> rose (remove 'r')
# rose -> ros (remove 'e')
# Example 2:

# Input: word1 = "intention", word2 = "execution"
# Output: 5
# Explanation: 
# intention -> inention (remove 't')
# inention -> enention (replace 'i' with 'e')
# enention -> exention (replace 'n' with 'x')
# exention -> exection (replace 'n' with 'c')
# exection -> execution (insert 'u')
 

# Constraints:

# 0 <= word1.length, word2.length <= 500
# word1 and word2 consist of lowercase English letters. -->

public class Solution {
    public int MinDistance(string word1, string word2) {
        int m=word1.Length;
        int n=word2.Length;
        int[,] dp=new int[m+1,n+1];
        for(int i=0;i<=m;i++)
        {
            dp[i,0]=i;
        }
        for(int j=0;j<=n;j++)
        {
            dp[0,j]=j;
        }
        for(int i=1;i<=m;i++)
        {
            for(int j=1;j<=n;j++)
            {
                if(word1[i-1]==word2[j-1])
                {
                    dp[i,j]=dp[i-1,j-1];
                }else{
                    dp[i,j]=1+Math.Min(dp[i-1,j-1],Math.Min(dp[i-1,j],dp[i,j-1]));
                }
            }
        }
        return dp[m,n];
        // for(int i=0;i<word1.Length;i++)
        // {
        //     for(int j=0;j<word2.Length;j++)
        //     {
        //         dp[i,j]=-1;
        //     }
        // }
        //return editDis(word1, word2, word1.Length-1, word2.Length-1, dp);
    }
    int editDis(string word1, string word2, int i, int j, int [,]dp)
    {
        if(i==-1||j==-1)
        {
            return i==-1? j+1:i+1;
        }
        if(dp[i,j]!=-1)
        {
            return dp[i,j];
        }
        if(word1[i]==word2[j])
        {
            return editDis(word1, word2, i-1, j-1, dp);
        }
        else{
            return dp[i,j]=1+Math.Min(editDis(word1, word2, i, j-1,dp),
            Math.Min(editDis(word1, word2, i-1, j-1,dp),editDis(word1, word2, i-1, j,dp)));
        }
    }
}
