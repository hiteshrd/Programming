
public class Solution {

    Dictionary<int,List<char>> myDic;
    public string SmallestStringWithSwaps(string s, IList<IList<int>> pairs) {
        
        int len = s.Length;
        Swap myswapper = new Swap(len);
        foreach(var pair in pairs)
        {
            myswapper.Merge(pair[0], pair[1]);
        }
        var myQueue = new PriorityQueue<char, char>[len];
        for (int i = 0; i < len; i++) {
            int j = myswapper.GetCurrentValue(i);
            myQueue[j] ??= new PriorityQueue<char, char>();
            myQueue[j].Enqueue(s[i], s[i]);
        }
        var sb = new StringBuilder();
        for (int i = 0; i < len; i++) {
            int j = myswapper.GetCurrentValue(i);
            sb.Append(myQueue[j].Dequeue());
        }
        return sb.ToString();
    }
}
public class Swap {
    int[] arr;
    int[] arrRank;
    
    public Swap(int len)
    {
        arr = new int[len];
        arrRank = new int[len];
        for(int i = 0; i<len; i++)
        {
            arr[i] = i;
            arrRank[i] = i;
        }
        
    }
    public void Merge(int num1, int num2)
    {
        int val1 = GetCurrentValue(num1);
        int val2 = GetCurrentValue(num2);
        if(val1 == val2)
        {
            return;
        }
        if(arrRank[val1] > arrRank[val2])
        {
            arr[val2] = val1;
            arrRank[val1] += arrRank[val2];
        }
        else
        {
            arr[val1] = val2;
            arrRank[val2] += arrRank[val1];
        }
    }
    
    public int GetCurrentValue(int num)
    {
        if (arr[num] == num) {
			return num;
		}
		return arr[num] = GetCurrentValue(arr[num]);
    }
}
