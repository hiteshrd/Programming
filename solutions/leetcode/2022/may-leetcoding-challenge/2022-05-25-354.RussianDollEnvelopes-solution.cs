public class Solution {
    public int MaxEnvelopes(int[][] envelopes) {
          Array.Sort(envelopes, (a, b) => a[0] == b[0] ? b[1].CompareTo(a[1]) : a[0].CompareTo(b[0]));

        int[] arr = new int[envelopes.Length];
        int result = 0;
        foreach(int[] envelope in envelopes)
        {
            int index = Array.BinarySearch(arr, 0, result, envelope[1]);
            if(index< 0)
                index = ~index;
            arr[index] = envelope[1];
            if(index == result)
                result++;
        }
        return result;
}
}
