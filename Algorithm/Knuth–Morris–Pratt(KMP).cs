// 28. Find the Index of the First Occurrence in a String

// Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

 

// Example 1:

// Input: haystack = "sadbutsad", needle = "sad"
// Output: 0
// Explanation: "sad" occurs at index 0 and 6.
// The first occurrence is at index 0, so we return 0.
// Example 2:

// Input: haystack = "leetcode", needle = "leeto"
// Output: -1
// Explanation: "leeto" did not occur in "leetcode", so we return -1.
 

// Constraints:

// 1 <= haystack.length, needle.length <= 104
// haystack and needle consist of only lowercase English characters.


public class Solution {
    public int StrStr(string haystack, string needle) {
        if(needle.Length==0)
        {
            return 0;
        }
        int[] lps = new int[needle.Length];
        lps=buildLPS(needle);
        int i=0, j=0;
        while(i<haystack.Length)
        {
            if(haystack[i]==needle[j])
            {
                i++;
                j++;
            }
            if(j==needle.Length)
            {
                return i-j;
            }
            else if(i<haystack.Length&&haystack[i]!=needle[j]){
                if(j>0)
                {
                    j=lps[j-1];
                }else{
                    i++;
                }
            }
        }
        return -1;
    }
    public int[] buildLPS(string needle)
    {
        int i=1,len=0;
        int[] lps = new int[needle.Length];
        lps[0]=0;
        while(i<needle.Length)
        {
            if(needle[i]==needle[len])
            {
                len++;
                lps[i]=len;
                i++;
            }
            else{
                if(len!=0)
                {
                    len=lps[len-1];
                }
                else{
                    lps[i]=0;
                    i++;
                }
            }
        }
        return lps;
    }
}
