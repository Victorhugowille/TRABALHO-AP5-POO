
using System;
namespace Cadastro_escolar.plataformacursos{

    public class Aula
    {
        public string Titulo { get; set; }
        public int DuracaoMinutos { get; set; }
        public string ProfessorResponsavel { get; set; } 

        public Aula(string titulo, int duracaoMinutos, string professorResponsavel)
        {
            Titulo = titulo;
            DuracaoMinutos = duracaoMinutos;
            ProfessorResponsavel = professorResponsavel;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"    Aula: {Titulo}, Duração: {DuracaoMinutos} min, Professor: {ProfessorResponsavel}");
        }
    }
}