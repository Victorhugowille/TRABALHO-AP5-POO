public class Exercicio
{
    public string Nome { get; set; }
    public int Series { get; set; }
    public int Repeticoes { get; set; }
    public double Carga { get; set; } // peso em kg

    public Exercicio(string nome, int series, int repeticoes, double carga)
    {
        Nome = nome;
        Series = series;
        Repeticoes = repeticoes;
        Carga = carga;
    }

    public double CalcularCargaTotal()
    {
        return Series * Repeticoes * Carga;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Exercício: {Nome}");
        Console.WriteLine($"Séries: {Series} | Repetições: {Repeticoes} | Carga: {Carga} kg");
        Console.WriteLine($"Carga Total: {CalcularCargaTotal()} kg");
    }
}
