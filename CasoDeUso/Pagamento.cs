using System;

public abstract class Pagamento
{
    public DateTime Data { get; set; }
    public abstract double Total { get; }
}

public class Especie : Pagamento
{
    public double Quantia { get; set; }
    public override double Total { get; }

    public Especie(double quantia, double total)
    {
        Quantia = quantia;
        Total = total;
    }
    public double Troco()
    {
        return Quantia - Total;
    }
}

public class Cheque : Pagamento
{
    public long Numero { get; set; }
    public DateTime DataDeposito { get; set; }
    public int Situacao { get; set; }
    public override double Total { get; }

    public Cheque(long numero, DateTime dataDeposito, int situacao, double total)
    {
        Numero = numero;
        DataDeposito = dataDeposito;
        Situacao = situacao;
        Total = total;
    }
}

public class Cartao : Pagamento
{
    public string DadosTransacao { get; set; }
    public int ResultadoTransacao { get; set; }
    public override double Total { get; }

    public Cartao(string dadosTransacao, int resultadoTransacao, double total)
    {
        DadosTransacao = dadosTransacao;
        ResultadoTransacao = resultadoTransacao;
        Total = total;
    }
}
