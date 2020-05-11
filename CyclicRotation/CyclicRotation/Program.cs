using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] A = {1,2,3,4};
            //int K = 5;

            RandomGenerator randomGenerator = new RandomGenerator();

            int[] A = randomGenerator.GenerateArray();
            int K = randomGenerator.GenerateK();

            int[] cycledA = Solution.solution(A, K);

            foreach (int element in A)
            {                
                Console.Write("{0}, ", element);
            }

            Console.WriteLine();
            Console.WriteLine("K = {0}", K);

            foreach (int element in cycledA)
            {
                Console.Write("{0}, ", element);
            }
        }
    }
}
