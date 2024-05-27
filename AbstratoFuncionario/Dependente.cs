public class Dependente
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Dependente(int codigo, string nome, int idade)
    {
        Codigo = codigo;
        Nome = nome;
        Idade = idade;
    }
}
