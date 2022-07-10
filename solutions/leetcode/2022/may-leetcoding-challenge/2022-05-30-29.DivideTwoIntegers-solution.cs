public class Solution {
    public int Divide(int dividend, int divisor) {
        long result = 0;
        long divid = Math.Abs((long)dividend);
        long divis = Math.Abs((long)divisor);        
        if (divisor == 0) 
            return int.MaxValue; 
        bool isNegative = dividend > 0 ^ divisor > 0;
        if (divis != 1)
        {
            for (long i = divis; i <= divid; i = i + divis)
            {
                result++;
            }
        }
        else
        {
            result = divid;
        }
        result *= isNegative ? -1 : 1;
        if (result > int.MaxValue || result < int.MinValue) 
            result = int.MaxValue;

        return (int)result;
    }
}
