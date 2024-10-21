using System;
namespace MyApp;
internal class Program
{
    static void Main(string[] args)
    {
        //int n = 34;
        //int m = 87;
        //int sum = 0;
        //if (n < m)
        //{
        //for (int i = n; i <= m; i++)
        //{
        //if (i % 2 == 1)
        //sum += i;
        //}

        //Console.WriteLine(sum);

        //int n = 12;
        //int product = 1;
        //bool even = false;
        //for (int i = 1; i <= n; i++)
        //{
        //if (i % 2 == 0)
        //{
        //product *= i;
        //even = true;
        //}
        //}
        //if (even)
        //{
        //Console.WriteLine(product);
        //}
        //else
        //{
        //Console.WriteLine("There is no even number");

        //int a = 28;
        //if (a % 6 == 0)
        //{
        //Console.WriteLine("Is even number & divisible by 3");
        //}
        //if (a % 3==0 && a%2==1)
        //{
        //Console.WriteLine("Is odd number & divisible by 3");
        //}
        //else if (a%3!=0)
        //{
        //Console.WriteLine("Is not divisible by 3");


        int n = 1;
        int factor = 0;
        if (n == 1)
        {
            Console.WriteLine("Neither prime, nor composite");
        }
        else if (n > 1)
        {
            for (int i = 2; i <= 45; i++)
            {
                if (n % i == 0)
                    factor++;
            }
            if (factor > 2)
            {
                Console.WriteLine("The number is composite");
            }
            else if (factor == 1)
            {
                Console.WriteLine("The number is prime");
            }

        }

        




             
    }    
}


