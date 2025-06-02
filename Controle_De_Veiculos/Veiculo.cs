using System;
using System.Collections.Generic;
using System.Linq;

public class Veiculo
{
    public string Modelo { get; private set; }
    public string Placa { get; private set; }
    public string Tipo { get; private set; }

    private List<Manutencao> manutencoes;

    public Veiculo(string modelo, string placa, string tipo)
    {
        Modelo = modelo;
        Placa = placa;
        Tipo = tipo;
        manutencoes = new List<Manutencao>();
    }

    public bool AdicionarManutencao(Manutencao manutencao)
    {
        bool existeMesmaData = manutencoes.Any(m => m.Data.Date == manutencao.Data.Date);
        if (existeMesmaData)
        {
            Console.WriteLine($"Erro: já existe manutenção para {Placa} em {manutencao.Data.ToShortDateString()}.");
            return false;
        }

        manutencoes.Add(manutencao);
        return true;
    }

    public List<Manutencao> GetManutencoes()
    {
        return new List<Manutencao>(manutencoes);
    }
}
