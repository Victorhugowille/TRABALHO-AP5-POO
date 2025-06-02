public class Aula
{
    public string Titulo { get; set; }
    public int DuracaoMinutos { get; set; }
    public string Professor { get; set; }

    public Aula(string titulo, int duracaoMinutos, string professor)
    {
        Titulo = titulo;
        DuracaoMinutos = duracaoMinutos;
        Professor = professor;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Aula: {Titulo} ({DuracaoMinutos} min) - Professor: {Professor}");
    }
}
