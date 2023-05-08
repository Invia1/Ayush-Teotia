using System;
public class fibbo 
{
    public static void notMain(string[] args)
    {
        int n1=0,n2=1,n3,num;
        Console.Write("enter a number :");
        num = int.Parse(Console.ReadLine());
        Console.Write(n1+" "+n2+" ");
        for(int i=2;i<num;i++){
            n3=n1+n2;
            Console.Write(n3 + " ");
            n1=n2;
            n2=n3;

        }

    }
}