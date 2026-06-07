// 22. Generate Parentheses

// Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

 

// Example 1:

// Input: n = 3
// Output: ["((()))","(()())","(())()","()(())","()()()"]
// Example 2:

// Input: n = 1
// Output: ["()"]
 

// Constraints:

// 1 <= n <= 8

public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        List<string> result = new List<string>();
        helper("", result, n, 0, 0);    
        return result;
    }
    void helper(string curr, List<string> list, int n, int open, int close)
    {
        if(curr.Length == 2*n)
        {
            list.Add(curr);
        }
        if(open<n)
        {
            helper(curr+'(',list,n, open+1, close);
        }
        if(close<open)
        {
            helper(curr+')',list,n, open, close+1);
        }
        return;
    }
}
