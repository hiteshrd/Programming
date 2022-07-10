public class Solution {
    public int MaxArea(int h, int w, int[] horizontalCuts, int[] verticalCuts) {
        long height = FindMax(h,horizontalCuts);
        long width = FindMax(w,verticalCuts);
        return (int) (height * width % 1000000007);
    }
    private int FindMax(int a, int[] lines)
    {
        Array.Sort(lines);
        int result = Math.Max(lines[0], a- lines[^1]);
        for(int i = 1; i<lines.Length; i++)
        {
            int temp = lines[i] - lines[i-1];
            result = Math.Max(temp,result);
        }
        return result;
    }
}
