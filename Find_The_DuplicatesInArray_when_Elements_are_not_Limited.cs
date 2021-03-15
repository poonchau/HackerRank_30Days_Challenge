using System;
using System.Collections.Generic; 

class Test{
	

static void findDuplicates(int[] arr, int len)
{
	bool ifPresent = false;

	
	List<int> mylist = new List<int>(); 

	for(int i = 0; i < len - 1; i++)
	{
		for(int j = i + 1; j < len; j++)
		{
			if (arr[i] == arr[j])
			{
				if (mylist.Contains(arr[i]))
				{
					break;
				}
				else
				{
					mylist.Add(arr[i]);
					ifPresent = true;
				}
			}
		}
	}

	if (ifPresent == true)
	{
		Console.Write("[" +mylist[0]+",");
		for (int i = 1; i < mylist.Count - 1; i++)
		{
			Console.Write(mylist[i]+ ",");
		}
		Console.Write(mylist[mylist.Count - 1]+ "]");
	}
	else
	{
		Console.Write("No duplicates present in arrays");
	}
}

// Driver code 
static void Main()
{
    string[] str = Console.ReadLine().Trim().Split(' ');
	
    int[] arr = Array.ConvertAll(str,Int32.Parse);
		
	int n = arr.Length;

	findDuplicates(arr, n);
}
}

// This code is contributed by divyesh072019
