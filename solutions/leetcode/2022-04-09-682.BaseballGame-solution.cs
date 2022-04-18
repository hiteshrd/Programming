public class Solution {
    public int CalPoints(string[] ops) {
        //int result = 0;
        int[] arr = new int[1000];
        int counter = 0;
        for(int i = 0; i< ops.Length; i++)
        {
            if(ops[i] == "+")
            {
                arr[counter] = arr[counter-1] + arr[counter-2];
                //result += arr[counter];
                counter++;
            }
            else if(ops[i] == "D")
            {
                arr[counter] = arr[counter-1] * 2;
                //result += arr[counter];
                counter++;
            }
            else if(ops[i] == "C")
            {
                //result -= arr[counter-1];                
                arr[counter-1] = 0;
                counter--;
            }
            else
            {
                arr[counter] = Convert.ToInt32(ops[i]);
                //result += arr[counter];
                counter++;
            }
        }
        for(int i = 1; i< counter; i++)
        {
            arr[0] += arr[i];
        }
        return arr[0];
        
    }
}
