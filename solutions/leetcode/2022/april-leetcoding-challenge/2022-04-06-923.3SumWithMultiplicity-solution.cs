public class Solution {
    public int ThreeSumMulti(int[] arr, int target) {
        long count = 0;
        long[] nums = new long[101];
        for(int i = 0; i< arr.Length; i++)
        {
            nums[arr[i]]++;
        }
        for(int num1 = 0; num1 < 101; num1++)
        {
            for(int num2 = num1; num2 < 101; num2++)
            {
                int num3 = target - num1 - num2;
                if(num3 >= 0  && num3 <= 100)
                {
                    if(num1 == num2 && num2 == num3)
                        count += (nums[num1]*(nums[num1]-1)*(nums[num1]-2))/6;
                    else if( num1 == num2 && num2 != num3)
                        count += ((nums[num1]*(nums[num1]-1))/2)*(nums[num3]);
                    else if( num1 < num2 && num2 < num3)
                        count += (nums[num1])*(nums[num2])*(nums[num3]);
                    count = count %(1000000007);
                }
                
            }
        }
        
        return Convert.ToInt32(count);
    }
}
