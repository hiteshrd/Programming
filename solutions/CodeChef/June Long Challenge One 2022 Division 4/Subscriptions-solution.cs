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
		    int count = arr[0] % 6 >0 ? (arr[0] /6) + 1:arr[0]/6;
		    result[i] = count * arr[1];
		}
		foreach(var item in result)
		{
		    Console.WriteLine(item);
		}
	}
}
