using System;

public class Test
{
	public static void Main()
	{
		// your code goes here
		int tc = Convert.ToInt32(Console.ReadLine());
		int[] result = new int[tc];
		for(int i = 0; i< tc; i++)
		{
		    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), a=> Convert.ToInt32(a));
		    result[i] = (arr[0]*10) + (arr[1]*90);
		}
		foreach(var item in result)
		{
		    Console.WriteLine(item);
		}
	}
}
