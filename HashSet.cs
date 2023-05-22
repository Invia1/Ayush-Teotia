using System;


namespace hashset
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            HashSet<int> even  = new HashSet<int>(); 
            HashSet<int> odd = new HashSet<int>();

            for(int i =0; i<=5; i++)
            {
                even.Add(i*2);
                odd.Add((i*2)+1);
            }

            Console.Write("EVEN NUMBERS :");
            foreach(var x in even)
            {
                Console.Write($"{ x},");
                Console.WriteLine();
                
            }
            Console.Write("ODD NUMBERS :");
            foreach (var x in odd)
            {
                Console.Write($"{x},");
                Console.WriteLine();

            }

            HashSet<int> numbers = new HashSet<int>(even);
            numbers.UnionWith(odd);

            Console.Write("All numbers in array");
            foreach(var y in numbers)
            { 
                Console.Write($"{ y},");
                

            }

        }
    }
}
