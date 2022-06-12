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
		    int diff = arr[1] - arr[0];
		    int j = diff/3;
		    int count = diff%3;
		    diff -= j*3;
		    j = 1;
		    while(count > 0 )
		    {
		        diff -= j%2 ==0 ? 2 : 1;
		        j++;
		        count--;
		    }
		    result[i] = diff <0 ? "NO" : "YES";
		}
		foreach(var item in result)
		{
		    Console.WriteLine(item);
		}
	}
}
