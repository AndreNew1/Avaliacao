
using System.Globalization;

namespace ID
{
    class Funcionario
    {
        public int I;
        string NOME;
        double Salario;

        public Funcionario(int i,string Nome,double SALARIO)
        {
            I = i;
            NOME = Nome;
            Salario = SALARIO;
        }

        public void Aumento(double desc)
        {
            Salario += Salario * desc / 100;
        }
        public override string ToString()
        {

            return I

                + ", "

                + NOME

                + ", "

                + Salario.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
