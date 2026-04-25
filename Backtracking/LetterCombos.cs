// 17. Letter Combinations of a Phone Number

// Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.

// A mapping of digits to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.


// Example 1:

// Input: digits = "23"
// Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]
// Example 2:

// Input: digits = "2"
// Output: ["a","b","c"]
 

// Constraints:

// 1 <= digits.length <= 4
// digits[i] is a digit in the range ['2', '9'].

public class Solution {
    public IList<string> LetterCombinations(string digits) {
        List<List<string>> list= new List<List<string>>();
        List<string> ans= new List<string>();
        int alpha=97;
        for(int i=0;i<=9;i++)
        {
            list.Add(new List<string>());
        }
        for(int i=2;i<=9;i++)
        {
            int limit=(i==7||i==9) ? 4:3;
            for(int j=0;j<limit;j++)
            {
                list[i].Add(((char)alpha).ToString());
                alpha++;
            }
        }
        helper(list, digits, "", 0, ans);
        return ans;
    }
    public void helper(List<List<string>> list, string digits, string current, int idx, List<string> ans)
    {
        if(idx==digits.Length)
        {
            ans.Add(current);
            return;
        }
        int digit=digits[idx]-'0';
        List<string> chrs=list[digit];
        foreach(var ch in chrs)
        {
            helper(list, digits, current+ch, idx+1, ans);
        }
        return;
    }
}
