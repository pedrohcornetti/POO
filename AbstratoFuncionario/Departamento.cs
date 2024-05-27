using System;
using System.Collections.Generic;
using System.Linq;

namespace AbstratoFuncionario
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public List<Funcionario> VetF { get; set; }

        public Departamento(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            VetF = new List<Funcionario>();
        }

        public void Admitir(Funcionario f)
        {
            VetF.Add(f);
        }

        public void ListarFuncionarios()
        {
            Console.WriteLine("\nListagem de departamento: " + Nome);
            foreach (Funcionario f in VetF)
                f.Mostrar();
        }

        public void Demitir(int codigo)
        {
            VetF.RemoveAll(f => f.Codigo == codigo);
        }

        public double CalcularFolha(int diasUteis)
        {
            double folha = 0;
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                folha += f.CalcularSalario(diasUteis);
            }
            return folha;
        }

        public int CalcularTotalDependentes()
        {
            int totalDependentes = 0;
            foreach (var func in VetF)
            {
                totalDependentes += func.CalcularTotalDependentes();
            }
            return totalDependentes;
        }
    }
}
