using System;

public class Test
{
	public static void Main()
	{
		// your code goes here
		int tc = Convert.ToInt32(Console.ReadLine());
		string[] result = new string[tc];
		for(int j = 0; j< tc; j++)
		{
		    int len = Convert.ToInt32(Console.ReadLine());
		    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), a=> Convert.ToInt32(a));
		    bool swapped = false;
		    result[j] = "YES";
		    for(int i = 0; i<len-1;i++)
		    {
		        if(arr[i] > arr[i+1])
		        {
		            if(swapped)
		            {
		                result[j] = "NO";
		                break;
		            }
		            swapped = true;
		            var temp = arr[i];
		            arr[i] = arr[i+1];
		            arr[i+1] = temp;
		        }
		    }
		}
		foreach(var item in result)
		{
		    Console.WriteLine(item);
		}
	}
}
