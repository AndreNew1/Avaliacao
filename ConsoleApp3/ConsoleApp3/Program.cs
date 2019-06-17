using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um numero");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma potencia");
            int B = int.Parse(Console.ReadLine());
            for(int i = 0; i < B; i++)
            {
                double C =Math.Pow(A,i+1);
                Console.WriteLine("Numero:" + C);
            }


            }

        }
      
    }

