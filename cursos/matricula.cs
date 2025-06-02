public class Matricula
{
    public Aluno Aluno { get; set; }
    public Curso Curso { get; set; }
    public DateTime DataInscricao { get; set; }
    public double Progresso { get; set; } 

    public Matricula(Aluno aluno, Curso curso)
    {
        Aluno = aluno;
        Curso = curso;
        DataInscricao = DateTime.Now;
        Progresso = 0.0;

        aluno.Matriculas.Add(this);
    }

    public void AtualizarProgresso(double novoProgresso)
    {
        if (novoProgresso < 0) novoProgresso = 0;
        if (novoProgresso > 100) novoProgresso = 100;
        Progresso = novoProgresso;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Curso: {Curso.Nome}");
        Console.WriteLine($"Data de Inscrição: {DataInscricao}");
        Console.WriteLine($"Progresso: {Progresso}%");
    }
}
