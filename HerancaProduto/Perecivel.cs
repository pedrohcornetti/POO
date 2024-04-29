using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Perecivel : Produto
    {
       private string dataFabricacao;
       private string dataValidade;
       private int lote;
       public Perecivel() : base()
       {
        
       }
       public Perecivel(int codigo, string nome, double preco, string dataFabricacao, string dataValidade, int lote) : base(codigo, nome, preco)
       {
            DataFabricacao = dataFabricacao;
            DataValidade = dataValidade;
            Lote = lote;
       }
         public void Mostrar()
         {
          base.Mostrar();
          Console.WriteLine("Data de Fabricação: " + DataFabricacao + "\tData de Validade: " + DataValidade + "\tLote: " + Lote);
         }
       public string DataFabricacao
       {
        get { return dataFabricacao; }
        set { dataFabricacao = value; }
       }
         public string DataValidade
         {
          get { return dataValidade; }
          set { dataValidade = value; }
         }
        public int Lote
        {
        get { return lote; }
        set { lote = value; }
        }
        
    }
}