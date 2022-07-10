public class Solution {
    public int MaxResult(int[] nums, int k) {
        int len = nums.Length;
        long[] scores = new long[len];
		
        for (int i = 0; i < len; i++) 
            scores[i] = long.MinValue;

        scores[0] = nums[0];
        k++;
        List<int> lst = new List<int>();
        lst.Add(0);

        for (int i = 1; i < len; i++)
        {
            if (i >= k && lst[0] == i - k)
                lst.RemoveAt(0);
            scores[i] = nums[i] + scores[lst[0]];
            while (lst.Count > 0 && scores[lst[lst.Count - 1]] <= scores[i])
                lst.RemoveAt(lst.Count - 1);
            lst.Add(i);
        }
        return (int)scores[len - 1];
    }
}
