public class Solution {
    public bool HasAllCodes(string s, int k) {
        double n = Math.Pow(2,k);
        HashSet<string> visited = new HashSet<string>();
        for (int i = k; i <= s.Length; i++)
        {
            string str = s.Substring(i - k, k);
            if (!visited.Contains(str))
            {
              visited.Add(str);
              if (visited.Count == n) 
                  return true;
            }
          }
          return false;
    }
}
