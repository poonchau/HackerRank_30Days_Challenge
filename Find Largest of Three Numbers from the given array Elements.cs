using System;

public class Test
{
	public static void Main()
	{
	   int first, second, third;
	   
	   int n = Convert.ToInt32(Console.ReadLine());
	   
	   string[] str = Console.ReadLine().Trim().Split(' ');
	   
	   /* for (int i = 0; i < n; i++)
	     {
	       
	         arr[i] = Convert.ToInt32(str[i]);
	     } */
	   
	   // above lines can be Replace with this one line 
	   int[] arr = Array.ConvertAll(str, Int32.Parse);
	   
	    third = first = second = 000;
	   
	    if (arr.Length < 3)
	    {
	        Console.WriteLine("Invalide Input");
	        return;
	    }
	   
	   for (int i = 0; i < n; i++)
	   {
	       
	       if (arr[i] > first){
	           third = second;
	           second = first;
	           first = arr[i];
	       }
	       
	       else if (arr[i] > second){
	             third = second;
	             second = arr[i];
	       }
	       
	       else if (arr[i] > third){
	           third = arr[i];
	       }
	       
	   }
	   
	  Console.WriteLine("Three distinct elements are: " + first + " " + second + " " + third);

	}
}
