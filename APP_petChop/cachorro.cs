public class Cachorro : Animal
{
    public string Raca { get; set; }
    public string Porte { get; set; } // Pequeno, Médio, Grande
    public string Temperamento { get; set; }

    public Cachorro(string nome, int idade, double peso, string dono, string raca, string porte, string temperamento)
        : base(nome, idade, peso, dono)
    {
        Raca = raca;
        Porte = porte;
        Temperamento = temperamento;
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Raça: {Raca}");
        Console.WriteLine($"Porte: {Porte}");
        Console.WriteLine($"Temperamento: {Temperamento}");
    }

    public override void BanhoETosa()
    {
        Console.WriteLine($"{Nome} (Cachorro) está sendo atendido para banho e tosa.");
    }
}
