using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Project_Euler_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger BiggestChain = 0;
            //Console.WriteLine(Numbers[0]); 
            for (BigInteger i = 1; i <= 1000000; i++)
            {
                BigInteger chain = CalculateingTheLength(i);
                if (chain > BiggestChain)
                {
                    BiggestChain = chain;
                    Console.WriteLine(i.ToString());
                }
            }
        }
        static BigInteger CalculateingTheLength(BigInteger number)
        {
            //Console.WriteLine(number);
            BigInteger counter = 0;
            while (number != 1)
            {
                //Console.WriteLine(number);
                counter++;
                if (number % 2 == 0)
                {
                    number /= 2;
                }
                else
                {
                    number *= 3;
                    number++;
                }
            }
            return counter;
        }
    }
}
