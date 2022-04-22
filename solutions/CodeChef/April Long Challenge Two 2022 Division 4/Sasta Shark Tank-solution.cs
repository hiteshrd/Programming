using System;

public class Test
{
	public static void Main()
	{
		// your code goes here
		int tc = Convert.ToInt32(Console.ReadLine());
		string[] result = new string[tc];
		for(int i = 0; i< tc; i++)
		{
		    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), a=> Convert.ToInt32(a));
		    if(arr[0]*10 > arr[1]*5)
		    {
		        result[i] = "FIRST";
		    }
		    else if(arr[0]*10 ==     arr[1]*5)
		    {
		        result[i] = "ANY";
		    }
		    else
		    {
		        result[i] = "SECOND";
		    }
		}
		foreach(var item in result)
		{
		    Console.WriteLine(item);
		}
	}
}
