// Using List<char> OR List<string>
using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
	public static void Main()
	{
		// your code goes here
		List<char> list1 = new List<char>();
		List<char> list2 = new List<char>();
		
		list1.Add('a');
		list1.Add('b');
		list1.Add('c');
		list1.Add('d');
		
		list2.Add('a');
		list2.Add('p');
		list2.Add('q');
		list2.Add('r');
	
	
	int pos=0, neg=0;
	for (int i = 0; i < list1.Count; i++){
	    if (list1[i] == list2[i])
	{
	    pos++;
	}
	else{
	    neg++;
	}
	}
	
	int res = (pos * 4) + (neg * (-1));
	
	        Console.WriteLine("No of right ans:" +pos);
		
		Console.WriteLine("No of wrong ans:" +neg);
		
		Console.WriteLine("Marks obtained:" +res);	
		
	}
}




// string array
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
