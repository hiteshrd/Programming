public class Solution {
    public bool ValidPalindrome(string s) {
        char[] sArr = s.ToCharArray();
        int count = sArr.Length;
        bool charDeleted = false;
        int start = 0;
        int end = count -1;
        return PerformValidation(sArr, start, end, charDeleted);
    }
    public bool CheckPalindrome(char[] sArr, int start, int end)
    {        
        while( start < end)
        {
            if(sArr[start] != sArr[end])
            {
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
    public bool PerformValidation(char[] sArr, int start, int end, bool charDeleted)
    {        
        while( start < end)
        {
            if(sArr[start] != sArr[end])
            {
                bool response = CheckPalindrome(sArr,start + 1, end);
                if(response)
                    return true;
                return CheckPalindrome(sArr,start, end -1);
            }
            else
            {
                start++;
                end--;
            }
        }
        return true;
    }
}
