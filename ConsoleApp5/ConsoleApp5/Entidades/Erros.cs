using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.Entidades
{
    class Erros:ApplicationException
    {
        public Erros(string mensagem):base(mensagem)
        {

        }
    }
}
