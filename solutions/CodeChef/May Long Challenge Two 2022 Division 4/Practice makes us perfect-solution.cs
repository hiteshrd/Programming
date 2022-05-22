using System;

public class Test
{
	public static void Main()
	{
		// your code goes here
		int result = 0;
	    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), a=> Convert.ToInt32(a));
	    for(int i = 0; i<4; i++)
	    {
	        if(arr[i] >= 10)
	            result++;
	    }
	    Console.WriteLine(result);
	}
}
