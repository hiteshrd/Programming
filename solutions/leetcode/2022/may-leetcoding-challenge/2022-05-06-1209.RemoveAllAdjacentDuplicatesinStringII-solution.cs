
public class Solution {
    public string RemoveDuplicates(string s, int k) {
        Stack<(char val, int freq)> st = new Stack<(char, int)>();
        int count = 0;
        int times = 1;
        foreach(var item in s)
        {
            if(st.Count > 0 && st.Peek().val == item )
            {
                var temp = st.Pop();
                temp.freq++;
                if(temp.freq != k)
                {
                    st.Push(temp);
                }
            }
            else
            {
                st.Push((item,1));
            }
        }
        StringBuilder result = new StringBuilder();
		var resultList = st.ToArray().Reverse();
		foreach ((char c, int freq) in resultList)            
		{
			result.Append(c, freq);
		}
		return result.ToString();
    }
}
