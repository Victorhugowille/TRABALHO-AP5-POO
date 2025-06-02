public class Aluno
{
    public string Nome { get; set; }
    public List<Matricula> Matriculas { get; set; }

    public Aluno(string nome)
    {
        Nome = nome;
        Matriculas = new List<Matricula>();
    }

    public void ExibirMatriculas()
    {
        Console.WriteLine($"Matrículas do aluno: {Nome}");
        foreach (var matricula in Matriculas)
        {
            matricula.ExibirInformacoes();
            Console.WriteLine("-----");
        }
    }
}
