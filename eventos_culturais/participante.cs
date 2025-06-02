public class Participante
{
    public string Nome { get; set; }
    public List<Evento> Eventos { get; set; }

    public Participante(string nome)
    {
        Nome = nome;
        Eventos = new List<Evento>();
    }

    public void ExibirEventos()
    {
        Console.WriteLine($"Eventos do participante {Nome}:");
        foreach (var evento in Eventos)
        {
            Console.WriteLine($"- {evento.Titulo} em {evento.Data.ToShortDateString()}");
        }
    }
}
