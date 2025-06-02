public class Palestra : Evento
{
    public string Palestrante { get; set; }
    public string Topico { get; set; }
    public int DuracaoMinutos { get; set; }

    public Palestra(string titulo, DateTime data, string horario, string local, int capacidade, string palestrante, string topico, int duracaoMinutos)
        : base(titulo, data, horario, local, capacidade)
    {
        Palestrante = palestrante;
        Topico = topico;
        DuracaoMinutos = duracaoMinutos;
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Palestrante: {Palestrante}");
        Console.WriteLine($"Tópico: {Topico}");
        Console.WriteLine($"Duração: {DuracaoMinutos} minutos");
    }
}
