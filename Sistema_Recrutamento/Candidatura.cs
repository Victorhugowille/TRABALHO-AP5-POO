using System;

public class Candidatura
{
    public Candidato Candidato { get; private set; }
    public Vaga Vaga { get; private set; }
    public DateTime DataEnvio { get; private set; }
    public string Status { get; set; } // enviada, em análise, aprovada, rejeitada

    public Candidatura(Candidato candidato, Vaga vaga, DateTime dataEnvio, string status)
    {
        Candidato = candidato;
        Vaga = vaga;
        DataEnvio = dataEnvio;
        Status = status;

        // Adiciona-se automaticamente aos objetos relacionados
        candidato.AdicionarCandidatura(this);
        vaga.AdicionarCandidatura(this);
    }
}
