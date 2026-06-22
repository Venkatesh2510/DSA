// 1189. Maximum Number of Balloons

// Given a string text, you want to use the characters of text to form as many instances of the word "balloon" as possible.

// You can use each character in text at most once. Return the maximum number of instances that can be formed.

 

// Example 1:



// Input: text = "nlaebolko"
// Output: 1
// Example 2:



// Input: text = "loonbalxballpoon"
// Output: 2
// Example 3:

// Input: text = "leetcode"
// Output: 0
 

// Constraints:

// 1 <= text.length <= 104
// text consists of lower case English letters only.

public class Solution {
    public int MaxNumberOfBalloons(string text) {
        Dictionary<char,int> dict = new Dictionary<char,int>();
        int n=text.Length;
        dict['b']=0;
        dict['a']=0;
        dict['l']=0;
        dict['o']=0;
        dict['n']=0;
        for(int i=0;i<n;i++)
        {
            if(dict.ContainsKey(text[i]))
            {
                dict[text[i]]++;
            }
        }
        dict['l']=dict['l']/2;
        dict['o']=dict['o']/2;
        int mini=10000;
        foreach(var i in dict)
        {
            mini=Math.Min(i.Value,mini);
        }
        return mini;
    }
}
