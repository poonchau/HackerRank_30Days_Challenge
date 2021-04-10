using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
	public static void Main()
	{
		// your code goes here
		string[] str1 = Console.ReadLine().Trim().Split(' ');
		string[] str2 = Console.ReadLine().Trim().Split(' ');
		
		

		
		
	//	var matchedAns = l1.Intersect(l2);
	//	var unmatchedAns = l1.Union(l2).Except(l1.Intersect(l2));
	
	int pos=0, neg=0;
	for (var i = 0; i < str1.Length; i++){
	    if (str1[i] == str2[i])
	{
	    pos++;
	}
	else{
	    neg++;
	}
	}
	
	var res = (pos * 4) + (neg * (-1));
	
		
		//Console.WriteLine(matchedAns.Count());
		
		//Console.WriteLine(unmatchedAns.Count());
		
		Console.WriteLine(pos);
		
		Console.WriteLine(neg);
		
		Console.WriteLine(res);
		
		
		
		
		
		
		
		
	}
}
