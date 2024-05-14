using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    public class ClienteJuridico : Cliente
    {
        private int cnpj;
        public ClienteJuridico(): base()
        {            
        }
        public ClienteJuridico(int codigo, string nome, string endereco,int idade, int cnpj) : base(codigo, nome, endereco,idade)
        {
            Cnpj = cnpj;
        }
        public override void Mostrar()
        
            {
            Console.WriteLine("Código: " + codigo +
            "\tNome: " + nome + "\tEndereço: "+ endereco + "\tCnpj: " + Cnpj );
            }
        
        public override void AvalaIdade()
        {
            if (idade >= 40)
            {
                Console.WriteLine("Cliente jurídico!");
            }
        }
        
        public int Cnpj{
            get { return cnpj;}
            set { cnpj = value;}
        }
    }
}