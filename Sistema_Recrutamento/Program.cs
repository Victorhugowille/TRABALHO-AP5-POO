using System;

class Program
{
    static void Main()
    {
        // Criar candidatos
        Candidato c1 = new Candidato("Alice Martins", "alice@gmail.com", "Engenheira de Software com 5 anos de experiência.");
        Candidato c2 = new Candidato("Bruno Lima", "bruno@gmail.com", "Analista de dados com foco em BI.");

        // Criar vagas
        Vaga v1 = new Vaga("Desenvolvedor .NET", "TechCorp", "Trabalho com APIs e sistemas web.");
        Vaga v2 = new Vaga("Analista de Dados", "DataWorks", "Modelagem e visualização de dados.");

        // Criar candidaturas
        Candidatura cand1 = new Candidatura(c1, v1, DateTime.Now, "enviada");
        Candidatura cand2 = new Candidatura(c2, v2, DateTime.Now, "enviada");
        Candidatura cand3 = new Candidatura(c1, v2, DateTime.Now, "em análise");

        // Mostrar vagas às quais Alice se candidatou
        Console.WriteLine($"\nCandidato: {c1.Nome}");
        foreach (var c in c1.GetCandidaturas())
        {
            Console.WriteLine($"- Vaga: {c.Vaga.Titulo} na {c.Vaga.Empresa} | Status: {c.Status}");
        }

        // Mostrar candidatos da vaga "Analista de Dados"
        Console.WriteLine($"\nVaga: {v2.Titulo} na {v2.Empresa}");
        foreach (var c in v2.GetCandidaturas())
        {
            Console.WriteLine($"- Candidato: {c.Candidato.Nome} | Status: {c.Status}");
        }
    }
}
