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
			find_prime_factor_ray(600851475143);
			Console.ReadLine();
		}

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
