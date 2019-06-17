using System;

namespace SOLU
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Nome Usuario>");
            string nomeUsuario = Console.ReadLine();
            x.RetornaString(nomeUsuario, 17, "brasil");
        }
        public string RetornaString(string nomeUsuario,int idadeUsuario = 20,string paisUsuario = "Brasil") 
        {
            if (nomeUsuario != null && idadeUsuario >= 18)
                return string.Format("Meu nome é {0} , moro no {1} e tenho {2} anos", nomeUsuario, paisUsuario, idadeUsuario);
            else if (nomeUsuario == null && idadeUsuario < 18)
                return ("O nome do usuario não pode ser NULO e deve ser de maior");
            else if (nomeUsuario == null)
                return ("O nome do usuario não pode ser NULO!");
            else
                return ("O usuario deve ser de maior");
        }
    }
}
