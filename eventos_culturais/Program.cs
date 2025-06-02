class Program
{
    static void Main(string[] args)
    {
        var oficina = new Oficina("Oficina de Pintura", new DateTime(2024, 7, 10), "14:00", "Sala 1", 10, "Tinta e pincel");
        var palestra = new Palestra("Palestra sobre História", new DateTime(2024, 7, 11), "16:00", "Auditório", 100, "Dra. Ana", "A História do Brasil", 90);
        var show = new Show("Show de MPB", new DateTime(2024, 7, 12), "20:00", "Teatro Principal", 200, "Banda Som Livre", "MPB", "Livre");

        var participante1 = new Participante("Carlos");
        var participante2 = new Participante("Mariana");

        oficina.AdicionarParticipante(participante1);
        palestra.AdicionarParticipante(participante1);
        palestra.AdicionarParticipante(participante2);
        show.AdicionarParticipante(participante1);
        show.AdicionarParticipante(participante2);

        Console.WriteLine("===== Eventos =====");
        oficina.ExibirInformacoes();
        Console.WriteLine("-----");
        palestra.ExibirInformacoes();
        Console.WriteLine("-----");
        show.ExibirInformacoes();

        Console.WriteLine("\n===== Participantes =====");
        participante1.ExibirEventos();
        Console.WriteLine("-----");
        participante2.ExibirEventos();
    }
}
