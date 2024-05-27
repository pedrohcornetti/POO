using System;
using System.Collections.Generic;

namespace AbstratoFuncionario
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public List<Dependente> Dependentes { get; set; } = new List<Dependente>();

        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome + "\tSalário: " + Salario);
        }

        public abstract double CalcularSalario(int diasUteis);

        public int CalcularTotalDependentes()
        {
            return Dependentes.Count;
        }

        public void AdicionarDependente(Dependente novoDep)
        {
            Dependentes.Add(novoDep);
        }

        public void RemoverDependente(int codigo)
        {
            Dependentes.RemoveAll(d => d.Codigo == codigo);
        }

        public void ListarDependentes()
        {
            foreach (var dep in Dependentes)
            {
                Console.WriteLine($"Nome: {dep.Nome}, Idade: {dep.Idade}");
            }
        }
    }
}
