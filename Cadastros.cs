using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MedindoAFebre_Eduardo_Seminotti
{
    public class Cadastros
    {
        private List<Pessoa> _pessoas = new List<Pessoa>();
      
        public Cadastros()
        {
            _pessoas.Add(new Pessoa(1, "Pessoa_1", "lages", "98646546546"));
            _pessoas.Add(new Pessoa(2, "Pessoa_2", "lages", "98646546546"));
            _pessoas.Add(new Pessoa(3, "Pessoa_3", "lages", "98646546546"));
            _pessoas.Add(new Pessoa(4, "Pessoa_4", "lages", "98646546546"));
            _pessoas.Add(new Pessoa(5, "Pessoa_5", "lages", "98646546546"));
            _pessoas.Add(new Fornecedor(6, "Fornecedor_6", "lages", "98646546546", 1000, 1500));
            _pessoas.Add(new Fornecedor(7, "Fornecedor_7", "lages", "98646546546", 200, 1500));
            _pessoas.Add(new Fornecedor(8, "Fornecedor_8", "lages", "98646546546", 1000, 900));
            _pessoas.Add(new Fornecedor(9, "Fornecedor_9", "lages", "98646546546", 30, 1500));
            _pessoas.Add(new Fornecedor(10, "Fornecedor_10", "lages", "98646546546", 1000, 1500));
            _pessoas.Add(new Empregado(11, "Empregado_11", "lages", "98646546546", 1, 1500, 9));
            _pessoas.Add(new Empregado(12, "Empregado_12", "lages", "98646546546", 2, 1500, 9));
            _pessoas.Add(new Empregado(13, "Empregado_13", "lages", "98646546546", 3, 2000, 10));
            _pessoas.Add(new Empregado(14, "Empregado_14", "lages", "98646546546", 1, 3000, 11));
            _pessoas.Add(new Empregado(15, "Empregado_15", "lages", "98646546546", 2, 5000, 12));
            _pessoas.Add(new Administrador(16, "Administrador_16", "lages", "98646546546", 2, 5000, 12, 600));
            _pessoas.Add(new Administrador(17, "Administrador_17", "lages", "98646546546", 1, 5500, 12, 600));
            _pessoas.Add(new Administrador(18, "Administrador_18", "lages", "98646546546", 2, 5000, 12, 600));
            _pessoas.Add(new Administrador(19, "Administrador_19", "lages", "98646546546", 3, 600, 12, 600));
            _pessoas.Add(new Administrador(20, "Administrador_20", "lages", "98646546546", 4, 5000, 12, 600));
            _pessoas.Add(new Operario(21, "Operario_21", "lages", "98646546546", 4, 1500, 9, 6000, 5));
            _pessoas.Add(new Operario(22, "Operario_22", "lages", "98646546546", 4, 1500, 9, 5000, 5));
            _pessoas.Add(new Operario(23, "Operario_23", "lages", "98646546546", 4, 1500, 9, 4000, 5));
            _pessoas.Add(new Operario(24, "Operario_24", "lages", "98646546546", 4, 1500, 9, 10000, 5));
            _pessoas.Add(new Operario(25, "Operario_25", "lages", "98646546546", 4, 1500, 9, 1500, 5));
            _pessoas.Add(new Vendedor(26, "Vendedor_26", "lages", "98646546546", 4, 1500, 9, 6000, 5));
            _pessoas.Add(new Vendedor(27, "Vendedor_27", "lages", "98646546546", 4, 1500, 9, 5000, 5));
            _pessoas.Add(new Vendedor(28, "Vendedor_28", "lages", "98646546546", 4, 1500, 9, 4000, 5));
            _pessoas.Add(new Vendedor(29, "Vendedor_29", "lages", "98646546546", 4, 1500, 9, 10000, 5));
            _pessoas.Add(new Vendedor(30, "Vendedor_30", "lages", "98646546546", 4, 1500, 9, 1500, 5));

        }

        public void BuscaCadastro(string op)
        {
            int codigo;

            try
            {
                codigo = Convert.ToInt32(op);
            }
            catch
            {
                Console.WriteLine("o valor informado não é um numero!");
                return;
            }

            var result = _pessoas.Where(x => x.Codigo.Equals(codigo)).ToList();

            foreach (var item in result)
            {
                item.DetalhaCadastro();
            }

        }

        public void ListarCadastros()
        {
            Console.WriteLine();
            Console.WriteLine("Listagem de todas as pessoas cadastradas.");
            Console.WriteLine();

            foreach (var item in _pessoas)
            {
                Console.WriteLine(item.ToString());
            }

        }


    }
}
