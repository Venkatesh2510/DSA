// 1358. Number of Substrings Containing All Three Characters

// Given a string s consisting only of characters a, b and c.

// Return the number of substrings containing at least one occurrence of all these characters a, b and c.

 

// Example 1:

// Input: s = "abcabc"
// Output: 10
// Explanation: The substrings containing at least one occurrence of the characters a, b and c are "abc", "abca", "abcab", "abcabc", "bca", "bcab", "bcabc", "cab", "cabc" and "abc" (again). 
// Example 2:

// Input: s = "aaacb"
// Output: 3
// Explanation: The substrings containing at least one occurrence of the characters a, b and c are "aaacb", "aacb" and "acb". 
// Example 3:

// Input: s = "abc"
// Output: 1
 

// Constraints:

// 3 <= s.length <= 5 x 10^4
// s only consists of a, b or c characters.

public class Solution {
    public int NumberOfSubstrings(string s) {
        int a=0,b=0,c=0,ans=0,i=0;
        for(int j=0;j<s.Length;j++)
        {
            if(s[j]=='a')
            {
                a++;
            }
            if(s[j]=='b')
            {
                b++;
            }
            if(s[j]=='c')
            {
                c++;
            }
            while(a>0&&b>0&&c>0)
            {
                ans+=s.Length-j;
                if(s[i]=='a')
                {
                    a--;
                }
                if(s[i]=='b')
                {
                    b--;
                }
                if(s[i]=='c')
                {
                    c--;
                }
                i++;
            }
        }
        return ans;
    }
}
