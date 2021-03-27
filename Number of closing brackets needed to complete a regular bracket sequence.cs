using System;

public class Test
{
	public static void Main()
	{
		// your code goes here
		
		string str = Console.ReadLine();
		completeSequence(str);
	}
	
	static void completeSequence(string s){
	    int n = s.Length;
	    int open = 0, close = 0;
	    for (int i = 0; i < n; i++)
	    {
	        if (s[i]=='('){
	            open++;
	        }
	        else{
	            close++;
	        }
	    }
	    
	    if (close > open){
	        Console.Write("IMPOSSIBLE");
	    }
	    else{
	        Console.WriteLine("No of closing bracket required is:" +(open - close));
	        Console.Write(s);
	        for (int i = 0; i < open - close; i++)
	        {
	            Console.Write(")");
	        }
	    }
	}
}
