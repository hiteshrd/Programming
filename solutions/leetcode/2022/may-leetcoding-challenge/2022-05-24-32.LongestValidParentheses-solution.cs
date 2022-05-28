public class Solution {
    public int LongestValidParentheses(string s) {
        Stack<int> st = new Stack<int>();
        int result = 0;
         for(int i  = 0; i< s.Length; i++)
         {
             if(s[i] == '(')
             {
                 st.Push(i);
             }
             else
             {
                 if(st.Count > 0 && s[st.Peek()] == '(')
                 {
                     st.Pop();
                 }
                 else
                 {
                     st.Push(i);
                 }
             }
         }
        if(st.Count == 0)
        {
            result = s.Length;
        }
        else
        {
            int min = 0;
            int max = s.Length;
            while(st.Count > 0)
            {
                min = st.Pop();
                result = Math.Max(result, max-min-1);
                max = min;                
            }
            result = Math.Max(result, max);
        }
        return result;
    }
}
