using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    public class GerenciadorBonificacao
    {
        public double totalBonificacao { get; private set; }
        public void totalizadorBonificacao(Funcionario funcionario)
        {
            totalBonificacao += funcionario.CalcularBonificacao();
        }
        public void totalizadorBonificacao(Secretario secretario)
        {
            totalBonificacao += secretario.CalcularBonificacao();
        }
        public void totalizadorBonificacao(Gerente gerente)
        {
            totalBonificacao += gerente.CalcularBonificacao();
        }
        public void totalizadorBonificacao(Diretor diretor)
        {
            totalBonificacao += diretor.CalcularBonificacao();
        }
        
    }
}
