using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente//extends
{   //         classe derivada : classe base
    public class ClienteFisico : Cliente
    {
        private int rg;
        public ClienteFisico(): base()
        {            
        }
        public void Mostrar()
        {
            Console.WriteLine("Código: " + codigo +
            "\tNome: " + nome + "\tEndereço: "+ endereco + "\tRg: " + Rg);
        }

        public ClienteFisico(int codigo, string nome, string endereco, int rg) : base(codigo, nome, endereco)
        {
            Rg = rg;
        }
        public int Rg{
            get { return rg;}
            set { rg = value;}
        }
    }
}