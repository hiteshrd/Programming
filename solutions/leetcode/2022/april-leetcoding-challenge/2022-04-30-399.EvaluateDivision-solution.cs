public class Solution {
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries) {
        double[] result = new double[queries.Count];
        Dictionary<string,Dictionary<string,double>> myDic = new Dictionary<string,Dictionary<string,double>>();
        HashSet<string> visited = new HashSet<string>();
        
        for(int i = 0; i < equations.Count; i++)
        {            
            if(!myDic.ContainsKey(equations[i][0]))
            {
                myDic[equations[i][0]] = new Dictionary<string,double>();
            }
            if(!myDic.ContainsKey(equations[i][1]))
            {
                myDic[equations[i][1]] = new Dictionary<string,double>();
            }
            myDic[equations[i][0]][equations[i][1]] = 1/values[i];
            myDic[equations[i][1]][equations[i][0]] = values[i];
        }
        for(int i = 0; i < queries.Count(); i++)
        {            
            result[i] = FindResult(queries[i][1], queries[i][0], myDic, visited);
        }
        return result;
    }
    public double FindResult(string start, string end,  Dictionary<string,Dictionary<string,double>> myDic, HashSet<string> visited)
    {
        if(!myDic.ContainsKey(start))
        {
            return -1.0;
        }
        if(start == end)
        {
            return 1.0;
        }
        double val = -1;
        visited.Add(start);
        foreach(string str in myDic[start].Keys)
        {
            if(visited.Contains(str))
            {
                continue;
            }
            val = FindResult(str,end, myDic, visited);
            if(val != -1)
            {
                val *= myDic[start][str];
                break;
            }
            
        }
        visited.Remove(start);
        return val;
    }
}