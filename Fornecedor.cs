using System;
using System.Collections.Generic;
using System.Text;

namespace MedindoAFebre_Eduardo_Seminotti
{
    public class Fornecedor : Pessoa
    {
        public double ValorCredito { get; set; }

        public double ValorDivida { get; set; }

        public Fornecedor(int codigo, string nome, string endereco, string telefone, double valorCredito, double valorDivida)
            : base(codigo, nome, endereco, telefone)
        {
            ValorCredito = valorCredito;
            ValorDivida = valorDivida;
        }


        public double obterSaldo()
        {
            return ValorCredito - ValorDivida;
        }

        public override void DetalhaCadastro()
        {

            base.DetalhaCadastro();
            Console.WriteLine($"Valor Credito         : {ValorCredito}");
            Console.WriteLine($"Valor Divida          : {ValorDivida} ");
            Console.WriteLine($"Saldo                 : {obterSaldo()}");
            

        }

    }
}
