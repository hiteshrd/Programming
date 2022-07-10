public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
        return s1.Length + s2.Length == s3.Length && IsValid(s1.Length -1,s2.Length-1,s3.Length-1,s1,s2,s3);
    }
    private bool IsValid(int i, int j, int k, string s1, string s2, string s3)
    {

        if(i == -1 && j == -1 && k == -1)
            return true;
        if(i >= 0 && j >= 0 && k >= 0 && s1[i] == s3[k] && s2[j] == s3[k])
        {
            
            return IsValid(i-1,j,k-1,s1,s2,s3) ||
                IsValid(i,j-1,k-1,s1,s2,s3);
        }
        if(i >=0 && k >= 0 && s1[i] == s3[k])
            return IsValid(i-1,j,k-1,s1,s2,s3);
        
        else if(j >=0 && k >= 0 && s2[j] == s3[k])
            return IsValid(i,j-1,k-1,s1,s2,s3);
        
        else 
            return false;
    }
}
