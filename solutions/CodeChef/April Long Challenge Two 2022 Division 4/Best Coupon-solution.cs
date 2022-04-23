using System;

public class Test
{
	public static void Main()
	{
		// your code goes here
		int tc = Convert.ToInt32(Console.ReadLine());
		double[] result = new double[tc];
		for(int i = 0; i< tc; i++)
		{
		    int bill = Convert.ToInt32(Console.ReadLine());
		    result[i] = bill*0.1 > 100 ? bill*0.1 : 100;
		}
		foreach(var item in result)
		{
		    Console.WriteLine(item);
		}
	}
}
