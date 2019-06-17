using System;
using System.Globalization;
namespace Conversao
{
    class Program
    {
        static void Main(string[] args)
        {

            double A = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            int B;
            double C;
            double D;
            if (A >= 0 && A <= 400)
            {
                B = 15;
                C = A * 1.15;
                D = A * 0.15;
            }
            if (A > 400 && A <= 800)
            {
                B = 12;
                C = A * 1.12;
                D = A * 0.12;
            }
            if (A > 800 && A <= 1200)
            {
                B = 10;
                C = A * 1.10;
                D = A * 0.10;
            }
            if (A > 1200 && A <= 2000)
            {
                B = 7;
                C = A * 1.07;
                D = A * 0.07;
            }
            else
            {
                B = 4;
                C = A * 1.04;
                D = A * 0.04;
            }

            Console.WriteLine("Novo salario: " + C.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + D.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + B.ToString("F2", CultureInfo.InvariantCulture) + "%");

            Console.ReadLine();
        }
    }
}