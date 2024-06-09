public class ItemVenda
{
    private int Quantidade { get; set; }
    private double Preco { get; set; }


    public ItemVenda(int quantidade, double preco)
    {
        Quantidade = quantidade;
        Preco = preco;
    }
    public double Subtotal()
    {
        return Quantidade < 50 ?Quantidade * Preco: Quantidade * Preco * 0.8;
    }
}
