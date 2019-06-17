using System;
namespace CARRO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int A = Convert.ToInt32(Console.ReadLine());
            int[] B = new int[A];
            int[] C = new int[A];
            double D;
            for (int i = 0; i < A; i++)
            {
                string[] s = Console.ReadLine().Split(" ");
                B[i] = Convert.ToInt32(s[0]);
                C[i] = Convert.ToInt32(s[1]);

            }

            for(int i = 0; i < A; i++)
            {
                if (C[i] != 0)
                {
                    D = (double)B[i] / C[i];
                    Console.WriteLine(D);
                }
                else Console.WriteLine("divisao impossivel");
            }
            Console.ReadKey();
        }
    }
}
