using System;

public class Test
{
	public static void Main()
	{
		// your code goes here
		string[] str = Console.ReadLine().Trim().Split(' ');
		
		int[] arr = Array.ConvertAll(str, Int32.Parse);
		

        findSecondLargest(arr);
		
		
	}
	
	static void findSecondLargest(int[] arr){
	    int f_max = arr[0];
	    for (int i = 1 ; i < arr.Length; i++)
		{
		    if (f_max < arr[i]){
		        
		        f_max = arr[i];
		    }
		    
		}
		
		int sec_max = arr[0];
		
		for (int i = 1 ; i < arr.Length; i++)
		{
		    if (f_max > arr[i] && sec_max < arr[i]){
		        
		        sec_max = arr[i];
		    }
		    
		}
		
		Console.Write(sec_max);

	}
}
