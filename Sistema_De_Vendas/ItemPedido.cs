public class ItemPedido
{
    public Produto Produto { get; private set; }
    public int Quantidade { get; private set; }

    public ItemPedido(Produto produto, int quantidade)
    {
        Produto = produto;
        Quantidade = quantidade;
    }

    public void AlterarQuantidade(int novaQuantidade)
    {
        Quantidade = novaQuantidade;
    }

    public double Subtotal()
    {
        return Produto.Preco * Quantidade;
    }
}
