public class Solution {
    public int MinCost(int[] houses, int[][] cost, int m, int n, int target) {
        Dictionary<int, Dictionary<int,int>> curr = new Dictionary<int, Dictionary<int,int>>();
        Dictionary<int, Dictionary<int,int>> prev = new Dictionary<int, Dictionary<int,int>>();
        Dictionary<int, Dictionary<int,int>> temp;
               
        if (houses[houses.Length-1] == 0)
        {  
            for(int i=1; i<= n; i++)
            {
                prev[i] = new Dictionary<int,int>();
                prev[i][1] = cost[houses.Length-1][i-1];
            }
        }
        else
        {
            prev[houses[houses.Length-1]] = new Dictionary<int,int>();
            prev[houses[houses.Length-1]][1] = 0;
        }
        
        
       for(int i= houses.Length-2; i>=0; i--)
       {
           if (houses[i] == 0)
           {
               for(int j=1; j<= n; j++)
               {
                   curr[j] = new Dictionary<int,int>();
                   PaintHouse(prev, curr[j], j, cost[i][j-1], target);
               }
           }
           else
           {
               curr[houses[i]] = new Dictionary<int,int>();
               PaintHouse(prev, curr[houses[i]], houses[i], 0, target);
           }
           
           temp = prev;
           prev = curr;
           curr = temp;
           curr.Clear();
       }
        
       int min = int.MaxValue;
           
       foreach(int key in prev.Keys)
        {
            if (prev[key].ContainsKey(target) && prev[key][target] < min)
            {
                min = prev[key][target];
            }
        }
              
       return (min == int.MaxValue)? -1: min; 
        
    }
    private void PaintHouse(Dictionary<int, Dictionary<int,int>> prev ,
                              Dictionary<int,int> curr, int color, int cost, int target)
    {
           int val = 0;
        
           foreach(int itemColor in prev.Keys)
           {   
               val = (itemColor == color)? 0 : 1;

               foreach(int neighborhood in prev[itemColor].Keys)
               {
                   if (neighborhood + val > target) 
                   {
                       continue;
                   }

                   if (curr.ContainsKey(neighborhood+val))
                   {
                       if (curr[neighborhood+val] > prev[itemColor][neighborhood] + cost)
                       {
                           curr[neighborhood+val] = prev[itemColor][neighborhood] + cost;
                       }
                   }
                   else
                   {
                      curr[neighborhood + val] = prev[itemColor][neighborhood] + cost; 
                   }

               }
           }
    }
}
