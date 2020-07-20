using System;

namespace MedindoAFebre_Eduardo_Seminotti
{
    class Program
    {
        static void Main(string[] args)
        {
            var cadastros = new Cadastros();

            var op = "";

            do
            {
                Console.WriteLine();
                Console.WriteLine("******** Gerenciamento de Cadastros ********");
                Console.WriteLine("Para listar todos os cadastros, informe [L], ou o numero do cadastro a ser detalhado:");
                Console.WriteLine("Para sair informe [sair]");
                op = Console.ReadLine().ToLower();

                if (op != "sair")
                {
                    if (op == "l")
                    {
                        cadastros.ListarCadastros();
                    }
                    else 
                    {
                        cadastros.BuscaCadastro(op);

                    }

                }





            } while (op != "sair");


        }
    }
}
