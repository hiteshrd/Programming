public class Solution {
    public int Candy(int[] ratings) {
        int len = ratings.Length;
        int[] candies = new int[len];
        candies[0] = 1;
        for(int i = 1; i < len; i++)
        {
            candies[i] = ratings[i] > ratings[i-1] ? candies[i-1] + 1 :1;
        }
        int result = candies[len-1];
        for(int i = len-2; i >= 0; i--)
        {
            if(ratings[i] > ratings[i+1] && candies[i] <= candies[i+1])
            {
                candies[i] = candies[i+1] + 1;
            }
            result += candies[i];
        }
        return result;
    }
}
