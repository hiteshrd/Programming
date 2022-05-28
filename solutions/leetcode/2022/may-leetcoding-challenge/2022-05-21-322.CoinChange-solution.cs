public class Solution {
    public int CoinChange(int[] coins, int amount) {
        if(amount <= 0 )
        {
            return 0;
        }
        int[] arr = new int[amount+1];
        for(int i = 0;i<arr.Length; i++)
            arr[i] = -1;
        for(int i = 0; i<= amount; i++)
        {
            foreach (var coin in coins)
            {
                if(i == coin)
                {
                    arr[i] = 1;
                }
                else if(i > coin)
                {
                    if(arr[i-coin] != -1 && ((arr[i] != -1 && arr[i] > arr[i-coin] +1) || arr[i] == -1))
                    {
                        arr[i] =arr[i-coin] + 1;
                    }
                }
                    
            }
        }
        return arr[amount];
    }
}
