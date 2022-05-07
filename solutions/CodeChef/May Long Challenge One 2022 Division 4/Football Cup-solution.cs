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
		    result[i] = arr[0] == arr[1] && arr[0] > 0 ? "YES": "NO";
		}
		foreach(var item in result)
		{
		    Console.WriteLine(item);
		}
	}
}
