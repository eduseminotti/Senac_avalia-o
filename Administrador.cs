using System;
using System.Collections.Generic;
using System.Text;

namespace MedindoAFebre_Eduardo_Seminotti
{
    public class Administrador : Empregado
    {
        public double AjudaDeCusto { get; set; }

        public Administrador(int codigo, string nome, string endereco, string telefone, int codigoSetor, double salarioBase, int porcentagemImposto, double ajudaDeCusto)
            : base(codigo, nome, endereco, telefone, codigoSetor, salarioBase, porcentagemImposto)
        {
            AjudaDeCusto = ajudaDeCusto;
        }

        public override double CalcularSalario()
        {
            base.SalarioBase += AjudaDeCusto;
            return base.CalcularSalario();
            
            //return base.SalarioBase - (base.SalarioBase * (PorcentagemImposto / 100));
        }

        public override void DetalhaCadastro()
        {

            base.DetalhaCadastro();
            Console.WriteLine($"Ajuda De Custo        : {AjudaDeCusto} ");


        }

    }
}
