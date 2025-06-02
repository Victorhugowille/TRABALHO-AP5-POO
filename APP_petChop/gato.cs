public class Gato : Animal
{
    public string Pelagem { get; set; }
    public string Comportamento { get; set; }

    public Gato(string nome, int idade, double peso, string dono, string pelagem, string comportamento)
        : base(nome, idade, peso, dono)
    {
        Pelagem = pelagem;
        Comportamento = comportamento;
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Pelagem: {Pelagem}");
        Console.WriteLine($"Comportamento: {Comportamento}");
    }
}
