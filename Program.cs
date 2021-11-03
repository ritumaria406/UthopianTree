using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
        
        // Calling the Uthopian Tree
            UthopianTree();
        }
        
          private static void UthopianTree()
        {
            Console.WriteLine("Enter the number of cycle");
            int cycle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The height of tree is {0}",TreeHeight(cycle));
        }
        
           private static int TreeHeight(int cycle)
        {
            // n denotes the number of year - 1 year consists of 2 cycle
            // If the cycle is even we can use the concept of 2^(n+1) - 1 
            // As n = cycle/2 so replacing the logic as 2^((cycle/2)+1) - 1
            if(cycle%2 == 0 && cycle > 0)
            {
                return Convert.ToInt32(Math.Pow(2,((cycle/2) + 1))) - 1;
            }
            else
            {
                return (Convert.ToInt32(Math.Pow(2, ((cycle-1)/2)+1)) - 1)*2;
            }
        }
     }
}
