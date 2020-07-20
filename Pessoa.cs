using System;
using System.Collections.Generic;
using System.Text;

namespace MedindoAFebre_Eduardo_Seminotti
{
    public class Pessoa
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }
        public String Endereco { get; set; }
        public String Telefone { get; set; }

        public Pessoa(int codigo, string nome, string endereco, string telefone)
        {
            Codigo = codigo;
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }

        public override string ToString()
        {
            return $"Codigo: {Codigo}, Nome: {Nome}, Endereco: {Endereco}, Telefone: {Telefone}  ";
        }

        public virtual void DetalhaCadastro()
        {
            Console.WriteLine($"Codigo                : {Codigo}");
            Console.WriteLine($"Nome                  : {Nome}");
            Console.WriteLine($"Endereco              : {Endereco}");
            Console.WriteLine($"Telefone              : {Telefone} ");
            

        }


    }
}
