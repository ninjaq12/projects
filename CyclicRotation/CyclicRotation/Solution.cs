using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclicRotation
{
    class Solution
    {
        static public int[] solution(int[] A, int K)
        {
            int[] B = new int[A.Length + 1];
            int n = 0;

            for (int i = 0; i < K; i++)
            {
                foreach (int element in A)
                {
                    B[n + 1] = element;
                    B[0] = B[B.Length - 1];
                    n++;
                }
                n = 0;
                A = B.Take(A.Length).ToArray();
            }

            return A;
        }
    }
}
