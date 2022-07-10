public class Solution {
    public int MaximumUnits(int[][] boxTypes, int truckSize) {
        int result = 0;
        foreach(var item in boxTypes.OrderByDescending(a=>a[1]))
        {
            if(truckSize == 0)
                break;
            if(item[0] <= truckSize)
            {
                result += item[0] * item[1];
                truckSize -= item[0];
            }
            else
            {
                result += truckSize * item[1];
                truckSize = 0;                
            }
        }
        return result;
    }
}
