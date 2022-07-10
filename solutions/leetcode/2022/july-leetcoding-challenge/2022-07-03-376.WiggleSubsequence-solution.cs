public class Solution {
    public int WiggleMaxLength(int[] nums) {
        int len = nums.Length;
        int prevDiff = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            var currNum = nums[i];
            var prevNum = nums[i - 1];

            var currDiff = currNum == prevNum ? 0 : currNum > prevNum ? 1 : -1;

            if (prevDiff == -1 && currDiff == 1 || prevDiff == 1 && currDiff == -1 || prevDiff == 0 && currDiff != 0)
                prevDiff = currDiff;
            else
                len--;
        }

        return len;
    }
}
