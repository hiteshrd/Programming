public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
        Dictionary<int, List<int[]>> dic = new Dictionary<int, List<int[]>>();
        int temp;
        int val;
        int result = int.MinValue;
        Queue<int> qe = new Queue<int>();
        int[] arr = new int[n+1];
        
        foreach(int[] item in times)
        {
            if (!dic.ContainsKey(item[0])) { dic[item[0]] = new List<int[]>(); }
            dic[item[0]].Add(item);
        }
        
        
        Array.Fill(arr, int.MaxValue);
        arr[k] = 0;
        
        
        qe.Enqueue(k);
        
        while(qe.Count > 0)
        {
            temp = qe.Dequeue();
            if (dic.ContainsKey(temp))
            {
                foreach(int[] vals in dic[temp])
                {
                    val =  arr[temp] + vals[2];
                    if (arr[vals[1]] > val)
                    {
                       arr[vals[1]]= val;
                       qe.Enqueue(vals[1]); 
                    }
                }
            }
        }
        for(int i=1; i< arr.Length; i++)
        {
            if (arr[i] == int.MaxValue) { return -1; }
            if (result < arr[i]) { result = arr[i]; }
        }
        
        return result;
    }
}
