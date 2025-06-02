class Program
{
    static void Main(string[] args)
    {
        // Criar animais
        var cachorro = new Cachorro("Thor", 5, 20.5, "Carlos", "Labrador", "Grande", "Amigável");
        var gato = new Gato("Mia", 3, 4.2, "Ana", "Curta", "Independente");
        var passaro = new Passaro("Loro", 2, 0.5, "Bruno", "Papagaio", 35);

        // Lista de animais
        var animais = new List<Animal> { cachorro, gato, passaro };

        // Exibir informações dos animais
        Console.WriteLine("===== Informações dos Animais =====");
        foreach (var animal in animais)
        {
            animal.ExibirInformacoes();
            Console.WriteLine("-----");
        }

        // Teste de banho e tosa
        Console.WriteLine("\n===== Teste de Banho e Tosa =====");
        foreach (var animal in animais)
        {
            Console.WriteLine($"Solicitando serviço para {animal.Nome}:");
            animal.BanhoETosa();
            Console.WriteLine("-----");
        }
    }
}
