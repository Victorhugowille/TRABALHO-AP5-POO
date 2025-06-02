public class Show : Evento
{
    public string Artista { get; set; }
    public string EstiloMusical { get; set; }
    public string ClassificacaoEtaria { get; set; }

    public Show(string titulo, DateTime data, string horario, string local, int capacidade, string artista, string estiloMusical, string classificacaoEtaria)
        : base(titulo, data, horario, local, capacidade)
    {
        Artista = artista;
        EstiloMusical = estiloMusical;
        ClassificacaoEtaria = classificacaoEtaria;
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Estilo Musical: {EstiloMusical}");
        Console.WriteLine($"Classificação Etária: {ClassificacaoEtaria}");
    }
}
