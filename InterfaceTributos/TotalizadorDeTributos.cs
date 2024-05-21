using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributos
{
    public class TotalizadorDeTributos
{
public double Total { get; private set; }
public void Adiciona(ITributavel t)
{
this.Total += t.CalculaTributos();
}
}
}