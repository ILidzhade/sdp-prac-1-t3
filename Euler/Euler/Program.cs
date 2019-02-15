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
        }

        public bool isPrime(int x)
        {
            int n = 1;
            int k = 2;
            while (n <= 2 && k <= x/2)
            {
                if (x % k == 0)
                {
                    k++;
                    n++;
                }
                else k++;
            }
            if (n == 2) return true;
            else return false;
        }
    }
}
