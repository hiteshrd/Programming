public class Solution {
    public int CountSubstrings(string s) {
        int result = 0;
        for(int i = 0; i<s.Length; i++)
        {
            result += FindPalindromes(s, i-1,i+1);
            result += FindPalindromes(s, i,i+1);
        }
        return result + s.Length;
    }
    private int FindPalindromes(string str, int i, int j)
    {
        int result = 0;
        while(i >=0 && j < str.Length)
        {
            if(str[i] != str[j])
                break;
            result++;
            i--;
            j++;
        }
        return result;
    }
}
