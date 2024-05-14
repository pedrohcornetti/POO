using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Assalariado : Funcionario
    {
        public Assalariado(int codigo, string nome, double salario) : base(codigo, nome, salario)
        {
        }
        public override double CalculaSalario(int diasUteis)
        {
            return Salario / 30 * diasUteis;
        }
    }
}