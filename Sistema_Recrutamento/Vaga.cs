using System;
using System.Collections.Generic;

public class Vaga
{
    public string Titulo { get; private set; }
    public string Empresa { get; private set; }
    public string Descricao { get; private set; }

    private List<Candidatura> candidaturas;

    public Vaga(string titulo, string empresa, string descricao)
    {
        Titulo = titulo;
        Empresa = empresa;
        Descricao = descricao;
        candidaturas = new List<Candidatura>();
    }

    public void AdicionarCandidatura(Candidatura candidatura)
    {
        candidaturas.Add(candidatura);
    }

    public List<Candidatura> GetCandidaturas()
    {
        return new List<Candidatura>(candidaturas);
    }
}
