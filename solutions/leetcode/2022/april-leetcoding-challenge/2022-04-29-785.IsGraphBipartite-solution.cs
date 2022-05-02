public class Solution {
    public bool IsBipartite(int[][] graph) {
        int len = graph.Length;
        Dictionary<int,int> setA = new Dictionary<int,int>();
        Dictionary<int,int> setB = new Dictionary<int,int>();
        Dictionary<int,bool> visited = new Dictionary<int,bool>();
        Stack<int> myStack = new Stack<int>();
        for(int i = 0; i< len; i++)
        {
            myStack.Push(i);
        }
        while(myStack.Count() > 0)
        {
            int i = myStack.Pop();
            if(visited.ContainsKey(i))
            {
                continue;
            }
            visited[i] = true;
            int lines = graph[i].Length;
            for(int j =0; j< lines; j++)
            {
                if(!setA.ContainsKey(i) && !setB.ContainsKey(i))
                {
                    if (setB.ContainsKey(graph[i][j]))
                    {
                        setA[i] = i;
                    }
                    else if(setA.ContainsKey(graph[i][j]))
                    {
                        setB[i] = i;
                    }
                    else
                    {
                        setA[i] = i;
                        setB[graph[i][j]] = graph[i][j];
                        myStack.Push(graph[i][j]);
                    }
                }
                else if(setA.ContainsKey(i))
                {
                    if(setA.ContainsKey(graph[i][j]))
                    {
                        return false;
                    }
                    if(!setB.ContainsKey(graph[i][j]))
                    {
                        setB[graph[i][j]] = graph[i][j];
                    }
                }
                else if(setB.ContainsKey(i))
                {
                    if(setB.ContainsKey(graph[i][j]))
                    {
                        return false;
                    }
                    if(!setA.ContainsKey(graph[i][j]))
                    {
                        setA[graph[i][j]] = graph[i][j];
                    }
                }
            }
        }
        return true;
    }
}
