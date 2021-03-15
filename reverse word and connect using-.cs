using System;

public class Test
{
	public static void Main()
	{
		// your code goes here
		
		string str = Console.ReadLine();
		char[] ch = new char[str.Length];
	    int k = 0;
	    
		for (int i = str.Length-1; i >=0; i--)
		{    
		   ch[k++] = str[i];
		}
		
		for (int i = 0; i < k ; i++)
		{
		    
		    if (i == k-1)
		    {
		        Console.Write(ch[i]);
		    }
		    else 
		    {
		        Console.Write(ch[i] + "-");
		    }
		    
		}
	}
}
