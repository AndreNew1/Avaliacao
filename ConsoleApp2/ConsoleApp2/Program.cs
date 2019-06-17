using System;
using System.Globalization;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            double A, B, C;

            string[] vet = Console.ReadLine().Split(" ");
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double pi = 3.14159;
            double triangulo = (A * C) / 2;
            double circulo = pi * Math.Pow(C, 2.0);
            double trapezio = (A + B) / 2 * C;
            double quadrado = Math.Pow(B, 2.0);
            double retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
