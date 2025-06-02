class Program
{
    static void Main(string[] args)
    {
        var aluno = new Aluno("Lucas", 25, "Hipertrofia", "Altura: 1.80m | Peso: 75kg");

        var treinoA = new Treino("Hipertrofia - Superior");
        treinoA.AdicionarExercicio(new Exercicio("Supino Reto", 4, 10, 60));
        treinoA.AdicionarExercicio(new Exercicio("Puxada Frontal", 3, 12, 45));
        treinoA.AdicionarExercicio(new Exercicio("Desenvolvimento Ombro", 3, 10, 30));

        var treinoB = new Treino("Resistência - Inferior");
        treinoB.AdicionarExercicio(new Exercicio("Agachamento Livre", 4, 12, 80));
        treinoB.AdicionarExercicio(new Exercicio("Leg Press", 3, 15, 120));
        treinoB.AdicionarExercicio(new Exercicio("Mesa Flexora", 3, 12, 40));

        aluno.AdicionarTreino(treinoA);
        aluno.AdicionarTreino(treinoB);

        aluno.ExibirTreinos();
    }
}
