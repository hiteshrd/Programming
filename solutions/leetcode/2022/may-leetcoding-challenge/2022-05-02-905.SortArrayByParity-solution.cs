public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        int evenNext = 0;
        int count = 0;
        while(count < nums.Length)
        {
            if(nums[count] % 2 == 0)
            {
                if(count > evenNext)
                {
                    int temp = nums[count];
                    nums[count] = nums[evenNext];
                    nums[evenNext] = temp;
                }
                count++;
                evenNext++;
            }
            else
            {
                count++;
            }
        }
        return nums;
    }
}
