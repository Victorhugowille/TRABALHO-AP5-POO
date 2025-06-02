public class Treino
{
    public DateTime DataCriacao { get; set; }
    public string Objetivo { get; set; } // hipertrofia, resistência, etc.
    public List<Exercicio> Exercicios { get; set; }

    public Treino(string objetivo)
    {
        DataCriacao = DateTime.Now;
        Objetivo = objetivo;
        Exercicios = new List<Exercicio>();
    }

    public void AdicionarExercicio(Exercicio exercicio)
    {
        Exercicios.Add(exercicio);
    }

    public double CalcularCargaTotalTreino()
    {
        return Exercicios.Sum(e => e.CalcularCargaTotal());
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Treino criado em: {DataCriacao}");
        Console.WriteLine($"Objetivo: {Objetivo}");
        Console.WriteLine("Exercícios:");

        foreach (var exercicio in Exercicios)
        {
            exercicio.ExibirInformacoes();
            Console.WriteLine("-----");
        }

        Console.WriteLine($"Carga Total do Treino: {CalcularCargaTotalTreino()} kg");
    }
}
