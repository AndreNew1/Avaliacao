using System;
using System.Globalization;
using ConsoleApp5.Entidades;
using ConsoleApp5;

public class ProcessFile
{
    public static void Main()
    {
        Console.WriteLine("Enter account data");
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Holder: ");
        String holder = Console.ReadLine();
        Console.Write("Initial balance: ");
        double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Withdraw limit: ");
        double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        ContaBancaria acc = new ContaBancaria(number, holder, balance, withdrawLimit);

        Console.WriteLine();
        Console.Write("Enter amount for withdraw: ");
        double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        try
        {
            acc.Sacar(amount);
            Console.WriteLine("New balance: " + acc.Conta.ToString("F2", CultureInfo.InvariantCulture));
        }
        catch (Erros e)
        {
            Console.WriteLine("Withdraw error: " + e.Message);
        }
    }
}