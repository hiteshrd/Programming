public class Solution {
    public int MissingNumber(int[] nums) {
        int n =nums.Length;
        int result = n;
        for(int i = 0;i<n;i++)
        {
            result += i - nums[i];
        }
        return result;
    }
}
