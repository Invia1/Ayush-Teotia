using System;
class program
{
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("select an option");
            Console.WriteLine("1. to generate fibbonaci series");
            Console.WriteLine("2. to calculate factorial");
            Console.WriteLine("3. to check prime numbers");
            Console.WriteLine("enter your choice(1-3):");
            if(!int.TryParse(Console.ReadLine(),out choice) || choice<1 || choice > 3)
            {
                Console.WriteLine("invalid option, please enter valid input (1-3");
            }
        }while(choice <1 ||  choice >3);

        switch (choice)
        {
            case 1: Console.Write("enter the number to print fibonacci");
                int n = int.Parse(Console.ReadLine());
                fibonacci(n);
                break;

            case 2:
                Console.Write("enter the number to find factorial");
                int num = int.Parse(Console.ReadLine());
                int fact = factorial(num);
                Console.WriteLine("factorial of {0} is {1}", num, fact);
                break;
            case 3:
                Console.Write("write a number to ceck prime number");
                int primeNum = int.Parse(Console.ReadLine());
                bool isprime = isPrime(primeNum);
                if (isprime)
                {
                    Console.WriteLine("{0} is a prime number", primeNum);

                }
                else
                {
                    Console.WriteLine("{0} is not a prime num", primeNum);

                }
                break;
            default:
                Console.WriteLine("invalid option");
                break;
        }
    }

    static void fibonacci(int n)
    {
        int a = 0, b = 1, c;
        Console.WriteLine("{0},{1}",a,b);
        for(int i=2; i < n; i++)
        {
            c = a + b;
            Console.WriteLine("{0}", c);
            a = b;
            b = c;

        }

    }

    static int factorial(int num)
    {
        int fact = 1;
        for(int i=1;i<=num; i++)
        {
            fact = fact * i;

        }
         return fact;
    }

    static bool isPrime(int primeNum)
    {
        if (primeNum == 1)
        {
            return false;
        }
        for(int i = 2; i <= primeNum / 2; i++)
        {
            if(primeNum % i == 0)
            {
                return false;
            } 

        }
        return true;
        
    }

}