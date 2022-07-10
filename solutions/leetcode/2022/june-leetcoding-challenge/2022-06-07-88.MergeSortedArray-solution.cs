public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        if(m == 0)
        {
            for(int j = 0; j< n;j++)
            {
                nums1[j] = nums2[j];
            }
            return;
        }
        if(n == 0)
            return;
        Queue<int> q = new Queue<int>();
        for(int a = 0; a< m; a++)
        {
            q.Enqueue(nums1[a]);
        }
        int i2 = 0;
        int i = 0;
        while(i<m+n)
        {
            if(q.Count == 0)
            {
                nums1[i] = nums2[i2];
                i2++;
            }
            else if(i2 >= n)
            {
                nums1[i] = q.Dequeue();
            }
            else
            {
                int temp = q.Peek();
                if(temp < nums2[i2])
                {
                    nums1[i] = q.Dequeue();
                }
                else
                {
                    nums1[i] = nums2[i2];
                    i2++;
                }
            }
            i++;            
        }
    }
}
