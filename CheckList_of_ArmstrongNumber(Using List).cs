using System;
using System.Collections.Generic;
using System.Linq;
public class Test
{
  public static void Main()
{
   List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
	    
   List<string> result = new List<string>();
     
   result = checkArm(arr);
    
      
   result.ForEach(Console.WriteLine); --It's the 1st n best option
   
   //foreach (var i in result) // it's second option
   // {
        Console.WriteLine(i);
   // }
	 
}
	
	
 static List<string> checkArm(List<int> arr)
	{ 
	   int num, r, sum = 0;
	   
	   List<string> mylist = new List<string>();
	  
	    foreach (int temp in arr)
	    {  
	        num = temp;
	        while (num != 0)
	        {
	            r = num % 10;
	            sum = sum + (r * r * r);
	            num = num / 10;
	        }
	        
	        if (sum == temp)
	        {
	            mylist.Add("It is an Armstrong number");
	        }
	        else{
	            mylist.Add("It is not an Armstrong number");
	        }
	        
	        
	        
	    }
	    return mylist;
	}
}
