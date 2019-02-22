using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("G17M0252");


            Console.WriteLine("enter the number of natural number ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int squares = 0;
            // method to calculate the suquare of each natural number up to the specified number by the user 
            //then adding the squares to get their sum 

            for (int i = 0; i <= n; i++)
            {
                squares = i * i;
                sum += squares;
                Console.Write("{0}", squares);
            }
            Console.WriteLine("\n Sum of squares up to {0} terms={1}\n", n, sum);  // the sum of squares is given as an output.

            int result = 0;
            int square = 0;

            //method to calculate the sum of all the natural numbers from 1 up to the given number by the user.
            // then calculating the square of that sum.
            for (int j = 0; j <= n; j++)
            {
                result += j;
                square = result * result;
                Console.Write("{0}", result);

            }
            Console.WriteLine("the square of the sum of natural numbers up to {0} terms={1}\n", n, square); // the square of sum is given as an output here.

            // subtracting the sum of square as calculated in the first part from the square of sum as calculated in the second part to get the difference and output the result.
            int difference = square - sum;
            Console.WriteLine("the difference between the sum of squares and square of sum of natural numbers up to {0} terms={1}\n", n, difference);

            Console.ReadLine();


            find_prime_factor_ray(600851475143);
            FibSum();
            Console.ReadLine();
        }

        /// <summary>
        /// Sums up all even terms in Fibonacci sequence
        /// and displays result
        /// </summary>
        /// 
        static void FibSum()
        {
            const long MAX_TERMS = 4000000; // max terms
            long term = 0; // to store nth term in fib seq
            int n = 1; // nth term counter
            long sum = 0;
            while (term < MAX_TERMS)
            {
                term = Fib(n++);
                sum += term;
            }
            Console.WriteLine($"Sum = {sum}");

        }// FibSum

        /// <summary>
        /// Gets the nth term of the Fibonacci sequence
        /// </summary>
        /// <param name="n">The nth term</param>
        /// <returns>The fibonacci number at n</returns>
        static long Fib(int n)
        {
            if (n < 0) throw new ArgumentException("Term must be a positive integer");
            if (n == 0) return 0; // Stop case 1
            if (n == 1) return 1; // Stop case 2

            return Fib(n - 1) + Fib(n - 2); // Recursive method
        }// Fib

        /// <summary>
        /// Checks if number is even
        /// </summary>
        /// <param name="number">The number to evalute if even</param>
        /// <returns>True when number is even, otherwise False.</returns>
        static bool isEven(long number)
        {
            return (number % 2 == 0);
        }// isEven
        
        /// <summary>
        /// Prints first n terms in Fibonacci sequence
        /// </summary>
        /// <param name="n">nth term of Fib seq</param>
        static void PrintFibSequence(int n)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                long term = Fib(i);
                sb.Append(term).Append("\n");
            }
            Console.WriteLine(sb.ToString());
        }// PrintFib

        public static bool isPrime(double x)
        {
            int n = 1;
            int k = 2;
            while (k < x && n <= 2)
            {
                if (x % k == 0)
                {
                    k++;
                    n++;
                }
                else k++;
            }
            if (n <= 2) return true;
            else return false;
        }

		public static double find_prime_factor(double x)
		{
			int k = 3;
			if (x % 2 == 0)
			{
				return 2;
			}
			while (x % k != 0)
			{
				k = k + 2;
				while (!isPrime(k))
				{
					k = k + 2;
				}
			}
			return k;
		}

		public static double ray_multiplier(List<double> ray)
		{
			double out_num = 1;
			foreach (double x in ray)
			{
				out_num = out_num * x;
			}
			return out_num;
		}

		public static void find_prime_factor_ray(double x)
		{
			List<double> ray = new List<double>();
			ray.Add(find_prime_factor(x));
			double workin_num = x / ray[ray.Count - 1];
			while (ray_multiplier(ray) != x)
			{
				ray.Add(find_prime_factor(workin_num));
				workin_num = workin_num / ray[ray.Count - 1];
			}
			Console.WriteLine("The largest prime factor of 600851475143 is " + ray[ray.Count - 1]);
		}
    }
}
