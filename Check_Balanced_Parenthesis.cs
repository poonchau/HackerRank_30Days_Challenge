using System;
using System.Collections.Generic;
 
public class BalancedBrackets {
    
        public int top = -1;
        
        
        public char[] items = new char[100];
      
 
         void push(char x)
        {       
            
                items[++top] = x;
            
        }
 
         char pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Underflow error");
                return '\0';
            }
            else
            {
                char element = items[top];
                top--;
                return element;
            }
        }
 
    
    
 
    
    static Boolean isMatchingPair(char ch1,
                                  char ch2)
    {
        if (ch1 == '(' && ch2 == ')')
            return true;
        else if (ch1 == '{' && ch2 == '}')
            return true;
        else if (ch1 == '[' && ch2 == ']')
            return true;
        else
            return false;
    }
 
    
    static Boolean areBracketsBalanced(char[] exp)
    {
      
        Stack<char> st = new Stack<char>();
 
        
        for (int i = 0; i < exp.Length; i++)
        {
            
            if (exp[i] == '{' || exp[i] == '('
                || exp[i] == '[')
                st.Push(exp[i]);
 
            
            if (exp[i] == '}' || exp[i] == ')'
                || exp[i] == ']') {
 
                
                if (st.Count == 0)
                {
                    return false;
                }
                else if (!isMatchingPair(st.Pop(),
                                         exp[i])) {
                    return false;
                }
            }
        }
 
        
 
        if (st.Count == 0)
            return true; // balanced
        else
        {
            // not balanced
            return false;
        }
    }
 
    // Driver code
    public static void Main(String[] args)
    {
       // char[] exp = { '{', '(', ')', '}', '[', ']' };
       
       string exp = Console.ReadLine();
       
       char[] ch = new char[exp.Length];
       
       
       ch = exp. ToCharArray();
 
        // Function call
        if (areBracketsBalanced(ch))
            Console.WriteLine("Balanced ");
        else
            Console.WriteLine("Not Balanced ");
    }
}