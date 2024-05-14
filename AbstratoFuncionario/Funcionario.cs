using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }
        public virtual void Mostrar()
        
        {
            Console.WriteLine("Código: " + Codigo +
            "\tNome: " + Nome + "\tSalário: "+ Salario);
        }
        public abstract double CalculaSalario(int diasUteis);
        //assinatura de método sabemos o que ele faz pelo nome dele, sabemos se precisa de um valor externo para atender o 
        //desenvolvimento da lógica (parâmetro) e se ocorrerá saída de valor (retorn)
    }
}