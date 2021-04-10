1] 
// return the Result in List

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        
	  
	  int n = Convert.ToInt32(Console.ReadLine());
	   
	   //string[] str = Console.ReadLine().Trim().Split(' ');
	   
	   List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
	   
	   
	   /* for (int i = 0; i < n; i++)
	     {
	       
	         arr[i] = Convert.ToInt32(str[i]);
	     } */
	   
	   // above lines can be Replace with this one line 
	  // int[] arr = Array.ConvertAll(str, Int32.Parse);
	   
	   List<int> res = new List<int>();
	   
	   res = findMaxThreeNumber(arr,n);
	   
	   res.ForEach(Console.WriteLine);
	   
    }
    
    static List<int> findMaxThreeNumber(List<int> mylist, int n){
	    
	    List<int> res = new List<int>();
	    int first, second, third;
	    
	    third = first = second = 000;
	   
	    if (mylist.Count < 3)
	    {
	        //Console.WriteLine("Invalide Input");
	        res.Add(0);
	        return res;
	    }
	   
	   for (int i = 0; i < n; i++)
	   {
	       
	       if (mylist[i] > first){
	           third = second;
	           second = first;
	           first = mylist[i];
	       }
	       
	       else if (mylist[i] > second){
	             third = second;
	             second = mylist[i];
	       }
	       
	       else if (mylist[i] > third){
	           third = mylist[i];
	       }
	       
	   }
	   
	   res.Add(first);
	   res.Add(second);
	   res.Add(third);
	   
	   return res;
	    
	}
}




2] same problem

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
