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
		    int n = Convert.ToInt32(Console.ReadLine());
		    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), a=> Convert.ToInt32(a));
		    int temp = 0;
		    for(int j = 0; j<4;j++)
		    {
		        if(temp < arr[j])
		            temp = arr[j];
		    }
		    result[i] = temp;
		}
		foreach(var item in result)
		{
		    Console.WriteLine(item);
		}
	}
}
