public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int len = cost.Length;
        int[] arr = new int[len];
        arr[len - 1] = cost[len - 1];
        arr[len - 2] = cost[len - 2];
        
        for (int i = len - 3; i >= 0; i--) 
        {
            arr[i] = Math.Min(arr[i + 1], arr[i + 2]) + cost[i];
        }
        return Math.Min(arr[0], arr[1]);
    }
}
