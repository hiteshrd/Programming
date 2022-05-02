public class Solution {
    public int MinCostConnectPoints(int[][] points) {
        int len = points.Length;
        bool[] nodevisited = new bool[len];
        nodevisited[0] = true;
        int count = 0;
        int current = 0;
        int[] arr = new int[len];
        for(int i = 1; i<len;++i)
        {
            arr[i] = Int32.MaxValue;
        }
        
        int dist = 0;
        
        while(count++<len-1)
        {
            
            //count++;
            int min = Int32.MaxValue;
            int next = -1;
            for(int i = 0; i<len;++i)
            {
                if(!nodevisited[i])
                {
                    int temp = Math.Abs(points[current][0] - points[i][0]) + 
                        Math.Abs(points[current][1] - points[i][1]);
                    if(arr[i] > temp)
                    {
                        arr[i] = temp;
                    }
                    if(min > arr[i])
                    {
                        min = arr[i];
                        next = i;
                    }
                    
                }
            }
            current = next;
            nodevisited[current] = true;
            dist += min;
        }
        return dist;
    }
}
