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
		    int count = Convert.ToInt32(Console.ReadLine());
		    result[i] = count*15 ;
		}
		foreach(var item in result)
		{
		    Console.WriteLine(item);
		}
	}
}
