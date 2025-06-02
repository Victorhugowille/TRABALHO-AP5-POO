class Program
{
    static void Main(string[] args)
    {
        // Criar cursos e aulas
        var curso1 = new Curso("História da Arte");
        curso1.AdicionarAula(new Aula("Introdução à História da Arte", 40, "Professora Helena"));
        curso1.AdicionarAula(new Aula("Arte Moderna e Contemporânea", 60, "Professora Helena"));
        curso1.AdicionarAula(new Aula("Análise de Obras e Movimentos", 50, "Professora Helena"));

        var curso2 = new Curso("Sociologia Contemporânea");
        curso2.AdicionarAula(new Aula("Fundamentos da Sociologia", 45, "Professor Marcos"));
        curso2.AdicionarAula(new Aula("Sociologia das Organizações", 50, "Professor Marcos"));
        curso2.AdicionarAula(new Aula("Movimentos Sociais Atuais", 55, "Professor Marcos"));

        // Criar alunos
        var aluno1 = new Aluno("Carolina");
        var aluno2 = new Aluno("Bruno");

        // Realizar matrículas
        var matricula1 = new Matricula(aluno1, curso1);
        var matricula2 = new Matricula(aluno1, curso2);
        var matricula3 = new Matricula(aluno2, curso2);

        // Atualizar progresso
        matricula1.AtualizarProgresso(60);
        matricula2.AtualizarProgresso(85);
        matricula3.AtualizarProgresso(40);

        // Exibir dados
        Console.WriteLine("===== Cursos =====");
        curso1.ExibirInformacoes();
        Console.WriteLine("-----");
        curso2.ExibirInformacoes();

        Console.WriteLine("\n===== Matrículas =====");
        aluno1.ExibirMatriculas();
        aluno2.ExibirMatriculas();
    }
}
