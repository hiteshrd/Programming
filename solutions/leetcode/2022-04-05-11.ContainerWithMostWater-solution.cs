public class Solution {
    public int MaxArea(int[] height) {
        int start = 0;
        int end = height.Length-1;
        int maxArea = 0;
        while(start < end)
        //for(int i = 0; i< count; i++)
        {
            int startheight = height[start];
            int endheight = height[end];
            int temp = (end-start)*( startheight > endheight? endheight : startheight);
            if(temp > maxArea)
                maxArea = temp;
            if(startheight > endheight)
            {
                end--;
            }
            else
            {
                start++;
            }
        }
        return maxArea;
    }
}
