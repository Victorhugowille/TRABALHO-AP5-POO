using System;

class Program
{
    static void Main()
    {
        Veiculo carro = new Veiculo("Corolla", "ABC-1234", "Passeio");

        Manutencao m1 = new Manutencao(new DateTime(2024, 5, 1), "Troca de óleo", "preventiva");
        Manutencao m2 = new Manutencao(new DateTime(2024, 5, 15), "Alinhamento e balanceamento", "preventiva");
        Manutencao m3 = new Manutencao(new DateTime(2024, 5, 1), "Reparo de freio", "corretiva"); // mesma data

        carro.AdicionarManutencao(m1);
        carro.AdicionarManutencao(m2);
        carro.AdicionarManutencao(m3); // deve dar erro

        Console.WriteLine($"\nHistórico de Manutenções do veículo {carro.Modelo} ({carro.Placa}):");
        foreach (var manut in carro.GetManutencoes())
        {
            Console.WriteLine($"{manut.Data.ToShortDateString()} - {manut.Tipo.ToUpper()}: {manut.Descricao}");
        }
    }
}
