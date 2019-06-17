using System;
using System.Globalization;
namespace syncro
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(" ");
            string[] sis = Console.ReadLine().Split(" ");

            int A = Convert.ToInt32(vet[0]);
            int B = Convert.ToInt32(vet[1]);
            double C = Convert.ToDouble(vet[2], CultureInfo.InvariantCulture);
            int D = Convert.ToInt32(sis[0]);
            int E = Convert.ToInt32(sis[1]);
            double F = Convert.ToDouble(sis[2], CultureInfo.InvariantCulture);

           double ValorFinal = (B * C) + (E * F);

            Console.WriteLine("VALOR A PAGAR: R$ " + ValorFinal.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
