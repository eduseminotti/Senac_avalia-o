using System;
using System.Collections.Generic;
using System.Text;

namespace MedindoAFebre_Eduardo_Seminotti
{
    public class Operario : Empregado
    {
        public double ValorProducao { get; set; }
        public int PorcentagemComissao { get; set; }

        public Operario(int codigo, string nome, string endereco, string telefone, int codigoSetor, double salarioBase,
            int porcentagemImposto, double valorProducao, int porcentagemComissao)
             : base(codigo, nome, endereco, telefone, codigoSetor, salarioBase, porcentagemImposto)
        {
            ValorProducao = valorProducao;
            PorcentagemComissao = porcentagemComissao;
        }


        public override double CalcularSalario()
        {
            var porcentagem = (double)PorcentagemComissao / 100;
            var comissao = (double ) ValorProducao * porcentagem;
            base.SalarioBase += comissao;
            return base.CalcularSalario();

            //return base.SalarioBase - (base.SalarioBase * (PorcentagemImposto / 100));
        }

        public override void DetalhaCadastro()
        {

            base.DetalhaCadastro();

            Console.WriteLine($"Valor Producao        : {ValorProducao} ");
            Console.WriteLine($"PorcentagemC omissao  : {PorcentagemComissao} ");


        }
    }

}
