using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclicRotation
{
    class RandomGenerator
    {
        Random random = new Random();
        
        public int[] GenerateArray()
        {
            int N = random.Next(100);

            int[] randomArray = new int[N];            

            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = random.Next(-1000, 1000);
            }

            return randomArray;
        }

        public int GenerateK()
        {            
            int K = random.Next(100);
            return K;
        }
    }
}
