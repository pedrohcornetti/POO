using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    public abstract class Cliente //abstract não pode ser instanciada
    {
        protected int codigo;
        protected string nome;
        protected string endereco;

        protected int idade;



        public Cliente()
        {
        }
        public Cliente(int codigo, string nome, string endereco, int idade)
        {
            Codigo = codigo;
            Nome = nome;
            Endereco = endereco;
            Idade = idade;
        }
        public abstract void Mostrar();

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public abstract void AvalaIdade();

    }
}