public class Solution {
    public int RemovePalindromeSub(string s) {
        if(string.Join("", s.Reverse().ToList()) == s)
            return 1;
        else
            return 2;
    }
}
