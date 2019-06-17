using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

 
            int A, B;

            Console.WriteLine("digite o primeiro valor");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o primeiro valor");
            B = int.Parse(Console.ReadLine());
         
            Console.WriteLine("SOMA = " + (A+B));

            Console.ReadLine();
        }
    }
}