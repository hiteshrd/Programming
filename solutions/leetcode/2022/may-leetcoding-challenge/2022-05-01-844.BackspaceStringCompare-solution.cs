public class Solution {
    public bool BackspaceCompare(string s, string t) {
        int count = 0;
        while(count < s.Length)
        {
            if(count<0)
                break;
            if(s[count] == '#')
            {
                StringBuilder str = new StringBuilder(s);
                if(count == 0)
                {
                    str.Remove(count,1);
                    count--;
                }
                else
                {
                    str.Remove(count-1,2);
                    count -=2;
                }
                s = str.ToString();
                
            }
            count++;
        }
        count = 0;
        while(count < t.Length)
        {
            if(count<0)
                break;
            if(t[count] == '#')
            {
                StringBuilder str = new StringBuilder(t);
                if(count == 0)
                {
                    str.Remove(count,1);
                    count--;
                }
                else
                {
                    str.Remove(count-1,2);
                    count -=2;
                }
                t = str.ToString();
            }
            count++;
        }
        return s==t;
    }
}
