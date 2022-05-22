using System;

public class Test
{
	public static void Main()
	{
		// your code goes here
		// your code goes here
		int tc = Convert.ToInt32(Console.ReadLine());
		int[] result = new int[tc];
		for(int i = 0; i< tc; i++)
		{
		    int n = Convert.ToInt32(Console.ReadLine());
		    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), a=> Convert.ToInt32(a));
		    for(int j = arr.Length - 1 ; j >=0; j--)
		    {
		        if(arr[j] != 0)
		        {
		            result[i] = j;
		            break;
		        }
		    }
		}
		foreach(var item in result)
		{
		    Console.WriteLine(item);
		}
	}
}
