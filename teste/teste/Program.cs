using System;
using System.Globalization;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            float A, B, C, D;
            string[] vet = Console.ReadLine().Split(" ");
            string[] sis = Console.ReadLine().Split(" ");

            A = float.Parse(vet[0], CultureInfo.InvariantCulture);
            B = float.Parse(vet[1],CultureInfo.InvariantCulture);
            C = float.Parse(sis[0], CultureInfo.InvariantCulture);
            D = float.Parse(sis[1], CultureInfo.InvariantCulture);

            float dis = (float)Math.Sqrt((float)Math.Pow((D - B), 2)+(float)Math.Pow((C - A), 2));

            Console.WriteLine("{0}", dis.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
