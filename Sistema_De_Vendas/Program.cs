using System;

class Program
{
    static void Main()
    {
        Produto notebook = new Produto("001", "Notebook", 3500.00);
        Produto mouse = new Produto("002", "Mouse", 150.00);
        Produto teclado = new Produto("003", "Teclado", 200.00);

        Pedido pedido = new Pedido();

        pedido.AdicionarItem(notebook, 1);
        pedido.AdicionarItem(mouse, 2);
        pedido.AdicionarItem(teclado, 1);

        Console.WriteLine("PEDIDO INICIAL:");
        MostrarPedido(pedido);

        // Removendo item
        pedido.RemoverItem(teclado);
        Console.WriteLine("\nDEPOIS DE REMOVER O TECLADO:");
        MostrarPedido(pedido);

        // Alterando quantidade
        pedido.AlterarQuantidade(mouse, 5);
        Console.WriteLine("\nDEPOIS DE ALTERAR QUANTIDADE DO MOUSE:");
        MostrarPedido(pedido);
    }

    static void MostrarPedido(Pedido pedido)
    {
        foreach (var item in pedido.GetItens())
        {
            Console.WriteLine($"{item.Quantidade}x {item.Produto.Nome} - Subtotal: R$ {item.Subtotal():F2}");
        }
        Console.WriteLine($"TOTAL: R$ {pedido.CalcularTotal():F2}");
    }
}
