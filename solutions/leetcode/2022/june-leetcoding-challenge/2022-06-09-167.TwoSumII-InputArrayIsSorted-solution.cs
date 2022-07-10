public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var left = 0;
        var rigth = numbers.Length - 1;        
        while(left < rigth)
        {
            var val = numbers[left] + numbers[rigth];
            if(val == target)
            {
                return new int[2]{left + 1, rigth + 1};
            }
            else if (val < target)
            {
                left++;
            }
            else
            {
                rigth--;
            }
        }        
        return null;
    }
}
