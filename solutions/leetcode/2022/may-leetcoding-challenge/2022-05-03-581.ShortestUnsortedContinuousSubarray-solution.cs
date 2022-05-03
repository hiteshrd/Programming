public class Solution {
    public int FindUnsortedSubarray(int[] nums) {
        int len = nums.Length;
        int start = 0;
        int end = len-1;
        int[] minList = new int[len];
        int[] maxList = new int[len];
        int tempMax = int.MaxValue;
        int tempMin = int.MinValue;
        for(int i =len-1; i>=0;i--)
        {
            tempMax = nums[i] > tempMax? tempMax:nums[i];
            minList[i] = tempMax;
        }
        for(int i =0; i<len;i++)
        {
            tempMin = nums[i] > tempMin? nums[i]:tempMin;
            maxList[i] = tempMin;
        }
        while(start<len && nums[start]<=minList[start])
        {
            start++;
        }
        while(end>=0 && nums[end]>=maxList[end])
        {
            end--;
        }
        return Math.Max(0, end-start+1);
    }
}
