public class Solution {
    public int NumberOfSteps(int num) {
        int result = 0;
        while(num>0)
            {
                if(num%2 == 0)
                    {
                    num=num/2;
                    }
            else{
                num--;
                }
            result++;
            }
        return result;
    }
}
