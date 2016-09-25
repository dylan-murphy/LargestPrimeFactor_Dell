using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPrimeFactor_C
{
    class Program
    {
        static void Main(string[] args)
        {
            const long number = 600851475143; //Number given
            int max = 0; //Starting answer.
            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (number%i == 0 && PrimeTest(i)) //Test for even division & prime
                {
                    max = i; // new max
                }

            }
            Console.WriteLine("-----");
            Console.WriteLine(max);
            Console.WriteLine("-----");
            Console.ReadKey();
        }

        //Prime Test using modulus.
        private static bool PrimeTest(int n)
        {
            for (int i = 2; i <= n/2; i++)
            {
                if(n%i == 0)
                {
                    return false;
                }

            }
            return true;
        }
    }
}
