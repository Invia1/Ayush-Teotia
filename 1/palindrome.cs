using System;  
namespace palindrome  
{  
    class Program  
    {  
        static void notMain(string[] args)  
        {  
            string s,revs="";  
            Console.WriteLine(" Enter string");  
            s = Console.ReadLine();  
            for (int i = s.Length-1; i >=0; i--) 
            {  
                revs += s[i].ToString();  
            }  
            if (revs == s) 
            {  
                Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);  
            }  
            else  
            {  
                Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);  
            }  
        }  
    }  
}