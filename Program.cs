using System;

            Console.Write("Enter the upper limit of the range: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The prime numbers between {0} and {1} are:", n1, n2);
            for (int i = n1; i <= n2; i++)
            {
                int count = 0;
                for (int j = 2; j <= i / 2; j++)
namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.Write("Enter the lower limit of the range: ");
            n1 = int.Parse(Console.ReadLine());
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }
                }
                if(count == 0 && i !=1)
                {
                	Console.WriteLine("{0} ", i);
                }
            }
        }
    }

}