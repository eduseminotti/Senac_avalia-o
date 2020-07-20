using System;
using System.Collections.Generic;
using System.Text;

namespace MedindoAFebre_Eduardo_Seminotti
{
    public class Vendedor : Empregado
    {
        public double ValorVendas { get; set; }
        public int PorcentagemComissao { get; set; }


        public Vendedor(int codigo, string nome, string endereco, string telefone, int codigoSetor, double salarioBase,
        int porcentagemImposto, double valorVendas, int porcentagemComissao)
        : base(codigo, nome, endereco, telefone, codigoSetor, salarioBase, porcentagemImposto)
        {
            ValorVendas = valorVendas;
            PorcentagemComissao = porcentagemComissao;
        }


        public override double CalcularSalario()
        {
            var porcentagem = (double)PorcentagemComissao / 100;
            var comissao = (double)ValorVendas * porcentagem;
            base.SalarioBase += comissao;
            return base.CalcularSalario();

            //return base.SalarioBase - (base.SalarioBase * (PorcentagemImposto / 100));
        }

        public override void DetalhaCadastro()
        {

            base.DetalhaCadastro();
            Console.WriteLine($"Valor Vendas          : {ValorVendas} ");
            Console.WriteLine($"Porcentagem Comissao  : {PorcentagemComissao} ");
        }


    }
}
