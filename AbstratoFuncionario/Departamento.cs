using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}