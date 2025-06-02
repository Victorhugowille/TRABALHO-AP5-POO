using System;
using System.Collections.Generic;
namespace Cadastro_escolar.hierarquia{
        public class Aluno : Pessoa
    {
    public string NumeroMatricula { get; set; } // Matrícula escolar do aluno
    public string Turma { get; set; }

    public Aluno(string nome, string cpf, DateTime dataNascimento, string numeroMatricula, string turma)
        : base(nome, cpf, dataNascimento)
    {
        NumeroMatricula = numeroMatricula;
        Turma = turma;
    }

    public override void Apresentar()
    {
        base.Apresentar();
        Console.WriteLine($"  Tipo: Aluno, Matrícula Escolar: {NumeroMatricula}, Turma: {Turma}");
    }
}
}