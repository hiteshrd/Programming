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
		    int N = arr[0];
		    int X = arr[1];
		    int Y = arr[2];
		    int temp = 0;
		    // horizontal
		    temp += N-1;
		    // Vertical
		    temp += N-1;
		    // Diagonal
		    temp += (2*(N-1)) - (Math.Abs(X-Y)) - (Math.Abs(X+Y - N-1)) ;
		    
		    result[i] = temp;
		    
		}
		foreach(var item in result)
		{
		    Console.WriteLine(item);
		}
	}
}
