<!-- 451. Sort Characters By Frequency

Given a string s, sort it in decreasing order based on the frequency of the characters. The frequency of a character is the number of times it appears in the string.

Return the sorted string. If there are multiple answers, return any of them.

 

Example 1:

Input: s = "tree"
Output: "eert"
Explanation: 'e' appears twice while 'r' and 't' both appear once.
So 'e' must appear before both 'r' and 't'. Therefore "eetr" is also a valid answer.
Example 2:

Input: s = "cccaaa"
Output: "aaaccc"
Explanation: Both 'c' and 'a' appear three times, so both "cccaaa" and "aaaccc" are valid answers.
Note that "cacaca" is incorrect, as the same characters must be together.
Example 3:

Input: s = "Aabb"
Output: "bbAa"
Explanation: "bbaA" is also a valid answer, but "Aabb" is incorrect.
Note that 'A' and 'a' are treated as two different characters.
 

Constraints:

1 <= s.length <= 5 * 105
s consists of uppercase and lowercase English letters and digits. -->

public class Solution {
    public string FrequencySort(string s) {
        Dictionary<char,int> dict = new Dictionary<char,int>();
        for(int i=0;i<s.Length;i++)
        {
            if(!dict.ContainsKey(s[i])){
                dict[s[i]]=1;
            }
            else{
                dict[s[i]]++;
            }
        }
        List<char>[] bucket = new List<char>[s.Length + 1];
        foreach(var kv in dict)
        {
            int f = kv.Value;
            if(bucket[f]==null)
            {
                bucket[f] = new List<char>();
            }
            bucket[f].Add(kv.Key);
        }
        StringBuilder ans = new StringBuilder();
        for(int i=s.Length;i>=0;i--)
        {
            if(bucket[i] == null)
            {
                continue;
            }
            foreach(char c in bucket[i])
            {
                for(int j=0;j<i;j++)
                {
                    ans.Append(c);
                }
            }
        }
        return ans.ToString();
        // PriorityQueue<char, int> pq = new PriorityQueue<char, int>();
        // foreach(var d in dict)
        // {
        //     pq.Enqueue(d.Key, -d.Value);
        // }
        // StringBuilder ans=new StringBuilder();
        // while(pq.Count>0)
        // {
        //     pq.TryDequeue(out char element, out int priority);
        //     int loop=-1*priority;
        //     while(loop>0)
        //     {
        //         ans.Append(element);
        //         loop--;
        //     }
        // }
        return ans.ToString();
    }
}
