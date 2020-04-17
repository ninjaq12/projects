using System;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {

            Solution(32);
            Solution(33);
            Solution(34);
            Solution(3432);

            Console.ReadLine();

        }

        static void Solution(Int64 N)
        {
            int gap = 0;
            int longest = 0;

            //Console.WriteLine("Enter number to convert to binary: ");

            //N = Convert.ToInt64(Console.ReadLine());
            N = Convert.ToInt64(N);

            string binary = Convert.ToString(N, 2);

            Console.WriteLine(N + " converted to binary is: " + binary);

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '0')
                {
                    gap += 1;

                    if (i < binary.Length - 1)
                    {
                        if (gap > longest && binary[i + 1] == '1')
                        {
                            longest = gap;
                        }
                    }

                }
                else
                {
                    gap = 0;
                }
            }

            Console.WriteLine("Longest binary gap is: " + longest);

        }



    }

}
