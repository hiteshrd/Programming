public class Solution {
    public int MinOperations(int[] nums, int x) {
        int n = nums.Length;
        int extra = nums.Sum() - x;
        int len =-1;
        int sum = 0;
        int left = 0;
        int right = 0;
        while(right<n)
        {
            sum += nums[right];
            while(sum >extra && left<= right)
            {
                sum -= nums[left];
                left++;
            }
            if(sum == extra)
            {
                len = Math.Max(len, right-left+1);
            }
            right++;
        }
        return len==-1?  -1: n- len;
    }
}
