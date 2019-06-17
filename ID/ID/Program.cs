using System;
using System.Globalization;
using System.Collections.Generic;
namespace ID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos empregados serão registrados");
            int N = Convert.ToInt32(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();
            for (int i = 1; i <= N; i++) {
                Console.WriteLine("Funcionario #" + i + ":");
                Console.WriteLine("Digite o Id do usuario:");
                int I =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o Nome do Funcionario:");
                String Nome = Console.ReadLine();
                Console.WriteLine("Digite o Salario:");
                double Salario = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario(I, Nome, Salario));
                Console.WriteLine();
            }
            Console.WriteLine("Entre com o id do funcionario que tera o aumento");
            int ID = Convert.ToInt32(Console.ReadLine());

            Funcionario emp = list.Find(x => x.I == ID);
            if (emp != null)
            {
                Console.WriteLine("Tamanho do Aumento");
                double desc = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);
                emp.Aumento(desc);
            }
            else
                Console.WriteLine("Funcionario Não encontrado");

            Console.WriteLine();
            Console.WriteLine("Lista de Funcionario");
            foreach(Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
