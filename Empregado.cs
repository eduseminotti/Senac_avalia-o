using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MedindoAFebre_Eduardo_Seminotti
{
    public class Empregado : Pessoa
    {
        public int CodigoSetor { get; set; }
        public double SalarioBase { get; set; }
        public int PorcentagemImposto { get; set; }

        public Empregado(int codigo, string nome, string endereco, string telefone,  int codigoSetor, double salarioBase, int porcentagemImposto)
            : base(codigo, nome, endereco, telefone)
        {
            CodigoSetor = codigoSetor;
            SalarioBase = salarioBase;
            PorcentagemImposto = porcentagemImposto;

        }


        public virtual double CalcularSalario()
        {
            double porcentagem = (double) PorcentagemImposto / 100;
            var salario = SalarioBase - (SalarioBase * porcentagem);

            return salario;
        }


        public override void DetalhaCadastro()
        {

            base.DetalhaCadastro();

            Console.WriteLine($"Codigo Setor          : {CodigoSetor}");
            Console.WriteLine($"Salario Base          : {SalarioBase} ");
            Console.WriteLine($"Porcentagem Imposto   : {PorcentagemImposto} ");
            Console.WriteLine($"Salario Real          : {CalcularSalario()}");
            


        }
    }
}
