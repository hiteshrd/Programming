public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 1 || nums.Length == 0)
            return nums.Length;
        Array.Sort(nums);
        int result = 1;
        int count = 1;
        for(int i = 1; i<nums.Length;i++)
        {
            if(nums[i] - nums[i-1] == 1)
            {
                count++;
            }
            else if(nums[i] == nums[i-1])
            {
                continue;
            }
            else
            {
                result = Math.Max(result,count);
                count = 1;
            }            
        }
        return Math.Max(result,count);;
    }
}
