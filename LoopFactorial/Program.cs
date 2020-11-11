using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopFactorial
{
    class Program
    {
        static int LoopFactorial(int num)
        {
            int result = 1;

            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);

            return result;
        }

        

        static void Main(string[] args)
        {
            LoopFactorial(7); 
        }
    }
}
