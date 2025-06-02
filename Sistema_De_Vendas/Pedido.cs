using System.Collections.Generic;
using System.Linq;

public class Pedido
{
    private List<ItemPedido> itens;

    public Pedido()
    {
        itens = new List<ItemPedido>();
    }

    public void AdicionarItem(Produto produto, int quantidade)
    {
        // Verifica se produto já está no pedido
        var existente = itens.FirstOrDefault(i => i.Produto == produto);
        if (existente != null)
        {
            existente.AlterarQuantidade(existente.Quantidade + quantidade);
        }
        else
        {
            itens.Add(new ItemPedido(produto, quantidade));
        }
    }

    public void RemoverItem(Produto produto)
    {
        itens.RemoveAll(i => i.Produto == produto);
    }

    public void AlterarQuantidade(Produto produto, int novaQuantidade)
    {
        var item = itens.FirstOrDefault(i => i.Produto == produto);
        if (item != null)
        {
            item.AlterarQuantidade(novaQuantidade);
        }
    }

    public double CalcularTotal()
    {
        return itens.Sum(item => item.Subtotal());
    }

    public List<ItemPedido> GetItens()
    {
        return new List<ItemPedido>(itens); // retorno protegido (encapsulamento)
    }
}
