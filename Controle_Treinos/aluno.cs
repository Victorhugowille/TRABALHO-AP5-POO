public class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string ObjetivoFisico { get; set; }
    public string MedidasCorporais { get; set; }
    public List<Treino> Treinos { get; set; }

    public Aluno(string nome, int idade, string objetivoFisico, string medidasCorporais)
    {
        Nome = nome;
        Idade = idade;
        ObjetivoFisico = objetivoFisico;
        MedidasCorporais = medidasCorporais;
        Treinos = new List<Treino>();
    }

    public void AdicionarTreino(Treino treino)
    {
        Treinos.Add(treino);
    }

    public void ExibirTreinos()
    {
        Console.WriteLine($"===== Treinos do Aluno: {Nome} =====");
        Console.WriteLine($"Idade: {Idade} anos");
        Console.WriteLine($"Objetivo Físico: {ObjetivoFisico}");
        Console.WriteLine($"Medidas Corporais: {MedidasCorporais}");

        foreach (var treino in Treinos)
        {
            Console.WriteLine("==========");
            treino.ExibirInformacoes();
        }
    }
}
