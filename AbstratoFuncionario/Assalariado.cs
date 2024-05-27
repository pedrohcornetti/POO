using System;
using System.Collections.Generic;

namespace AbstratoFuncionario
{
    public class Assalariado : Funcionario
    {
        public Assalariado(int codigo, string nome, double salario) : base(codigo, nome, salario)
        {
        }

        public override double CalcularSalario(int diasUteis)
        {
            return Salario / 30 * diasUteis;
        }
    }
}
