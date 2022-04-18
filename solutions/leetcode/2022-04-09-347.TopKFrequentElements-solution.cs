public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> myDic = new Dictionary<int,int>();
        for(int i = 0; i< nums.Length; i++)
        {
            if(myDic.ContainsKey(nums[i]))
            {
                myDic[nums[i]]++;
            }
            else
            {
                myDic[nums[i]] = 1;
            }
        }
        int[] elem = new int[k];
        int counter = 0;
        foreach(var item in myDic.OrderByDescending(a=>a.Value))
        {
            elem[counter] = item.Key;
            counter++;
            if(counter > k-1)
                break;
        }
        return elem;
    }
}
