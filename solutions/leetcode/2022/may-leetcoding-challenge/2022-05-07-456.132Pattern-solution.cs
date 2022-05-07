public class Solution {
    public bool Find132pattern(int[] nums) {
        Stack<int> st = new Stack<int>();
        int val = int.MinValue;
        for(int i = nums.Length - 1; i >= 0; i--)
        {
            if(val > nums[i])
            {
                return true;
            }

            while(st.Count > 0 && nums[i] > st.Peek())
            {
                val = Math.Max(val, st.Pop());
            }

            st.Push(nums[i]);
        }

        return false;
    }
}
