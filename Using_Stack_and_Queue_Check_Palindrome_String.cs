using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    //Write your code here
    int top = -1;
    char alph;
    char qele;
    int front = 0;
    int rear = 0;
    Stack<char> s = new Stack<char>();
    void pushCharacter(char ch) 
    {
        s.Push(ch);
        top++;
    }
    
    Queue<char> q = new Queue<char>();
    
    void enqueueCharacter(char ch)
    {   
        q.Enqueue(ch);
        rear++;   
    }
    
    char popCharacter()
    {
        if (top != -1)
        {
             alph = s.Pop();
             top--;
        }
       // else
       //  {
        //   return(Console.WriteLine("stack is underflow"));  
         //}
        
        return alph;
    } 
    
    char dequeueCharacter()
    { if (front < rear || front == rear)
       {
        qele = q.Dequeue();
        front++;
       }
       
       return qele;
        
    }
    


    static void Main(String[] args) {
        // read the string s.
        string s = Console.ReadLine();
        
        // create the Solution class object p.
        Solution obj = new Solution();
        
        // push/enqueue all the characters of string s to stack.
        foreach (char c in s) {
            obj.pushCharacter(c);
            obj.enqueueCharacter(c);
        }
        
        bool isPalindrome = true;
        
        // pop the top character from stack.
        // dequeue the first character from queue.
        // compare both the characters.
        for (int i = 0; i < s.Length / 2; i++) {
            if (obj.popCharacter() != obj.dequeueCharacter()) {
                isPalindrome = false;
                
                break;
            }
        }
        
        // finally print whether string s is palindrome or not.
        if (isPalindrome) {
            Console.Write("The word, {0}, is a palindrome.", s);
        } else {
            Console.Write("The word, {0}, is not a palindrome.", s);
        }
    }
}