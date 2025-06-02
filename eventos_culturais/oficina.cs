public class Oficina : Evento
{
    public string MaterialNecessario { get; set; }

    public Oficina(string titulo, DateTime data, string horario, string local, int capacidade, string materialNecessario)
        : base(titulo, data, horario, local, capacidade)
    {
        MaterialNecessario = materialNecessario;
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Material Necessário: {MaterialNecessario}");
    }
}
