public class Solution {
    public IList<string> LetterCombinations(string digits) {
        int[] arr = digits.Select(a=>a-'0').ToArray();
        Dictionary<int,string[]> btn = new Dictionary<int,string[]>();
        Queue<string>q1 = new Queue<string>();
        Queue<string>q2 = new Queue<string>();
        bool isq1Empty = true;
        btn[2] = new string[]{"a","b","c"};
        btn[3] = new string[]{"d","e","f"};
        btn[4] = new string[]{"g","h","i"};
        btn[5] = new string[]{"j","k","l"};
        btn[6] = new string[]{"m","n","o"};
        btn[7] = new string[]{"p","q","r","s"};
        btn[8] = new string[]{"t","u","v"};
        btn[9] = new string[]{"w","x","y","z"};
        for(int i = 0; i < arr.Length;i++)
        {
            if(isq1Empty)
            {
                PrepareData(q1, q2,btn[arr[i]]);
                isq1Empty = false;
            }
            else
            {
                PrepareData(q2, q1,btn[arr[i]]);
                isq1Empty = true;
            }
        }
        return isq1Empty ? q2.ToArray() : q1.ToArray();
    }
    private void PrepareData(Queue<string> q1, Queue<string> q2, string[] data)
    {
        if(q2.Count() == 0)
        {
            for(int i = 0; i< data.Length;i++)
            {
                q1.Enqueue(data[i]);
            }          
        }
        while(q2.Count() > 0)
        {
            var temp = q2.Dequeue();
            for(int i = 0; i< data.Length;i++)
            {
                q1.Enqueue(temp + data[i]);
            }
        }
    }
}
