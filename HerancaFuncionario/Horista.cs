using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Horista : Funcionario
    {
        protected int qtdeHorasSemana;
        public Horista() : base()
        {

        }
        public Horista(int codigo, string nome, double salario, int qtdeHorasSemana) : base(codigo, nome, salario)
        {
            QtdeHorasSemana = qtdeHorasSemana;
        }
        public void Mostrar() {
             Console.WriteLine("Código: " + codigo + "\nNome: " + nome + "\nSalário: " + salario + "\nQuantidade de horas por semana: " + qtdeHorasSemana);
        }
        public int QtdeHorasSemana{
            get { return qtdeHorasSemana; }
            set { qtdeHorasSemana = value; }
        }

    }
}