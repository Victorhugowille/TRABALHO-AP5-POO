public class Curso
{
    public string Nome { get; set; }
    public List<Aula> Aulas { get; set; }

    public Curso(string nome)
    {
        Nome = nome;
        Aulas = new List<Aula>();
    }

    public void AdicionarAula(Aula aula)
    {
        Aulas.Add(aula);
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Curso: {Nome}");
        Console.WriteLine("Aulas:");
        foreach (var aula in Aulas)
        {
            aula.ExibirInformacoes();
        }
    }
}
