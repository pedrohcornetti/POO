using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributavel
{
    public class TotalizadordeTributos
    {
        public double Total { get; private set; }

        public void Adiciona(ITributavel t)
        {
            this.Total += t.CalcularTributos();
        }   
    }
}