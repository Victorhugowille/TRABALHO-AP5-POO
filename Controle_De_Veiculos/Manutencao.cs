using System;

public class Manutencao
{
    public DateTime Data { get; private set; }
    public string Descricao { get; private set; }
    public string Tipo { get; private set; } // preventiva ou corretiva

    public Manutencao(DateTime data, string descricao, string tipo)
    {
        Data = data;
        Descricao = descricao;
        Tipo = tipo;
    }
}
