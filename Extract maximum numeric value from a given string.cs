// C# program to extract the maximum value 
using System; 

class findMaxNumricval { 
	
	// Method to extract the maximum value 
	static int extractMaximum(String str) 
	{ 
		int num = 0, res = 0; 
	
		// Start traversing the given string 
		for (int i = 0; i < str.Length; i++) 
		{ 
			
			/*  
			 This method is used to check whether the specified string at specified position matches with any decimal digit or not.
			 If it matches then it returns True otherwise returns False. 
			 If a numeric value comes, start 
			 converting it into an integer 
			 till there are consecutive 
			 numeric digits */
			
			if (char.IsDigit(str[i])) 
				num = num * 10 + (str[i]-'0'); 
	
			// Update maximum value 
			else
			{ 
				res = Math.Max(res, num); 
	
				// Reset the number 
				num = 0; 
			} 
		} 
	
		// Return maximum value 
		return res;
	} 
	
	// Driver method 
	public static void Main() 
	{
		
		string str = Console.ReadLine();
		
		Console.Write(extractMaximum(str)); 
	} 
} 

// This code is contributed by nitin mittal. 
