public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, char> dic = new Dictionary<char,char>();
        int count = 0;
        int result = 0;
        if(s.Length == 1)
            return 1;
        for(int i = count; i<s.Length;i++)
        {
            if(!dic.ContainsKey(s[i]))
            {
                dic.Add(s[i],s[i]);
            }
            else
            {
                result = result > dic.Count ? result: dic.Count;
                dic = new Dictionary<char,char>();
                count++;
                i = count-1;
            }
        }
        return result > dic.Count ? result: dic.Count;;
    }
}
