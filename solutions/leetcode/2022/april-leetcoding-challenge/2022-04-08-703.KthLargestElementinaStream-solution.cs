public class KthLargest {
    private int kth = 0;
    private SortedDictionary<int,int> myDic = null;
    private int counter = 0;

    public KthLargest(int k, int[] nums) {
        kth = k;
        myDic = new SortedDictionary<int,int>();
        for(int i = 0; i<nums.Length; i++)
        {
            Add(nums[i]);
        }
    }
    
    public int Add(int val) {
        counter++;
        if(myDic.ContainsKey(val))
        {
            myDic[val]++;
        }
        else
        {
            myDic.Add(val,1);
        }
        if(counter > kth)
        {
            counter--;
            var kthElement = myDic.First();
            if(kthElement.Value > 1)
            {
                myDic[kthElement.Key]--;
            }
            else
            {
                myDic.Remove(kthElement.Key);
            }
        }
        return myDic.First().Key;
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */
