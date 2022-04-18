public class Solution {
    public void NextPermutation(int[] nums) {
        int start = nums.Length - 2;        
        int swapper = nums.Length-1;
        while(start >=0)
        {
            if(nums[start] < nums[start+1])
                break;
            start--;
        }
        if(start >= 0)
        {
            while(swapper >= 0)
            {
                if(nums[swapper] > nums[start])
                    break;
                swapper--;
            }
            Swap(nums,start, swapper);
        }
        start++;
        swapper = nums.Length -1;
        while(start<swapper)
        {
            Swap(nums,start, swapper);
            start++;
            swapper--;
        }
    }
    public void Swap(int[] nums, int num1, int num2)
    {
            int temp = nums[num1];
            nums[num1] = nums[num2];
            nums[num2] = temp;        
    }
}
