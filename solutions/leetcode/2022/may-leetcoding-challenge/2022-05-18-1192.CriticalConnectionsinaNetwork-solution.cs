public class Solution {
    int[] nodes;
    Dictionary<(int,int), int> edges;
    Dictionary<int, List<int>> dic;
    public IList<IList<int>> CriticalConnections(int n, IList<IList<int>> connections) {
        
        IList<IList<int>> result = new List<IList<int>>();
        IList<IList<int>> nodes = new List<IList<int>>();
        
        for(int i=0;i<n;i++)
            nodes.Add(new List<int>());
        
        foreach(var connection in connections)
        {
            nodes[connection[0]].Add(connection[1]);
            nodes[connection[1]].Add(connection[0]);
        }
        int count = 1;
        GetConnection(nodes,0,0,ref count,new int[n],new int[n],result);
        
        return result;
        
    }
    private int GetConnection(IList<IList<int>> nodes, int node, int parent, ref int count, int[] arr, int[] minArr,IList<IList<int>> result)
    {
        if(arr[node]!=0)
            return arr[node];
        
        arr[node] = count++;
        minArr[node] = arr[node];
        
        foreach(int nd in nodes[node])
        {
            if(nd==parent)
                continue;
            
            int val = GetConnection(nodes,nd,node,ref count,arr,minArr,result);
            minArr[node] = Math.Min(minArr[node], val);
            
            if(arr[node] < minArr[nd])
                result.Add(new List<int>{node,nd});
        }
        
        return minArr[node];
    }
}
