using System;
using System.Collections.Generic;

public class Candidato
{
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public string Curriculo { get; private set; }

    private List<Candidatura> candidaturas;

    public Candidato(string nome, string email, string curriculo)
    {
        Nome = nome;
        Email = email;
        Curriculo = curriculo;
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
