public class Produto
{
    public string Codigo { get; private set; }
    public string Nome { get; private set; }
    public double Preco { get; private set; }

    public Produto(string codigo, string nome, double preco)
    {
        Codigo = codigo;
        Nome = nome;
        Preco = preco;
    }
}
