public class Passaro : Animal
{
    public string Especie { get; set; }
    public double Envergadura { get; set; } // em centímetros

    public Passaro(string nome, int idade, double peso, string dono, string especie, double envergadura)
        : base(nome, idade, peso, dono)
    {
        Especie = especie;
        Envergadura = envergadura;
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Espécie: {Especie}");
        Console.WriteLine($"Envergadura: {Envergadura} cm");
    }
}
