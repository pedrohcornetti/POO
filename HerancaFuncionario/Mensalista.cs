using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Mensalista : Funcionario
    {
        protected int qtdeHorasTrabalhadas;
        public Mensalista() : base()
        {
            
        }
        public Mensalista(int codigo, string nome, double salario, int qtdeHorasTrabalhadas) : base(codigo, nome, salario)
        {
            QtdeHorasTrabalhadas = qtdeHorasTrabalhadas;
        }
        public void Mostrar() {
            Console.WriteLine("Código: " + codigo + "\nNome: " + nome + "\nSalário: " + salario + "\nQuantidade de horas trabalhadas: " + qtdeHorasTrabalhadas);
        }
        public int QtdeHorasTrabalhadas{
            get { return qtdeHorasTrabalhadas; }
            set { qtdeHorasTrabalhadas = value; }
        }
    }
}