public class Evento
{
    public string Titulo { get; set; }
    public DateTime Data { get; set; }
    public string Horario { get; set; }
    public string Local { get; set; }
    public int Capacidade { get; set; }
    public List<Participante> Participantes { get; set; }

    public Evento(string titulo, DateTime data, string horario, string local, int capacidade)
    {
        Titulo = titulo;
        Data = data;
        Horario = horario;
        Local = local;
        Capacidade = capacidade;
        Participantes = new List<Participante>();
    }

    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Evento: {Titulo}");
        Console.WriteLine($"Data: {Data.ToShortDateString()} - Horário: {Horario}");
        Console.WriteLine($"Local: {Local}");
        Console.WriteLine($"Capacidade: {Capacidade}");
        Console.WriteLine($"Participantes inscritos: {Participantes.Count}");
    }

    public void AdicionarParticipante(Participante participante)
    {
        if (Participantes.Count < Capacidade)
        {
            Participantes.Add(participante);
            participante.Eventos.Add(this);
        }
        else
        {
            Console.WriteLine($"Evento {Titulo} está com a capacidade esgotada.");
        }
    }
}
