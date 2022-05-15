public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) {
        Stack<int> st = new Stack<int>();
        IList<IList<int>> result = new List<IList<int>>();
        FindNumbers(1,k,n,st,result);
        return result;
    }
    private void FindNumbers(int start, int k, int n, Stack<int> st, IList<IList<int>> result)
    {
        if(n == 0 && k == 0)
        {
            result.Add(st.ToList());
            return;
        }
        if(n<=0 ||k==0)
        {
           return;
        }
        for(int i = start; i<=9; i++)
        {
            st.Push(i);
            FindNumbers(i+1,k-1,n-i,st,result);
            st.Pop();
        }
    }
}
