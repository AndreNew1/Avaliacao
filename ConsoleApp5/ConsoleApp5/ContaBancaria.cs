
using System.Globalization;
using ConsoleApp5.Entidades;
namespace ConsoleApp5
{
    public class ContaBancaria
    {
        public int NumC { get; set; }
        public string Titular{get;set;}
        public double Conta { get; set; }
        public double Limit { get; set; }
        public ContaBancaria(int numC,string titular)
        {
            NumC = numC;
            Titular = titular;
            Conta = 0;

        }
        public ContaBancaria(int numero,string titular,double conta,double limit)
        {
            NumC = numero;
            Titular = titular;
            Conta = conta;
            Limit = limit;
        }

        public void Deposito(double Valor=0)
        {
            Conta += Valor;
        }
        public void Sacar(double Valor=0)
        {
            if(Valor>Limit)
            {
                throw new Erros("valor passou o limite de saque");
            }
            if(Valor>Conta)
            {
                throw new Erros("valor passou o limite da conta");
            }

            Conta -= Valor;
        }
        public override string ToString()
        {
            return "Numero da Conta:"
                +NumC
                +", Titular:"
                +Titular
                +", Saldo da Conta R$"
                +Conta.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
