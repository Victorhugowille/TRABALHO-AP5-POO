public class Animal
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public double Peso { get; set; }
    public string Dono { get; set; }

    public Animal(string nome, int idade, double peso, string dono)
    {
        Nome = nome;
        Idade = idade;
        Peso = peso;
        Dono = dono;
    }

    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Animal: {Nome}");
        Console.WriteLine($"Idade: {Idade} anos");
        Console.WriteLine($"Peso: {Peso} kg");
        Console.WriteLine($"Dono: {Dono}");
    }

    public virtual void BanhoETosa()
    {
        Console.WriteLine("Este serviço não está disponível para este tipo de animal.");
    }
}
