using System;
using System.Collections.Generic;

public class Venda
{
    public DateTime Data { get; set; }
    private List<ItemVenda> itensVenda = new List<ItemVenda>();

    public double Total
    {
        get
        {
            double total = 0;
            foreach (var item in itensVenda)
            {
                total += item.Subtotal();
            }
            return total;
        }
    }

    public Venda(DateTime data)
    {
        Data = data;
    }

    public void AdicionarItem(ItemVenda item)
    {
        itensVenda.Add(item);
    }
}
