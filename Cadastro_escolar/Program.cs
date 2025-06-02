using System;
using System.Collections.Generic;
using Cadastro_escolar.hierarquia;
using Cadastro_escolar.plataformacursos;

namespace SistemaEducacional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Sistema de Cadastro Escolar (Herança e Polimorfismo) ---");

            Aluno aluno1 = new Aluno("Carlos Silva", "111.222.333-44", new DateTime(2005, 5, 10), "A2023001", "7A");
            Professor prof1 = new Professor("Ana Souza", "222.333.444-55", new DateTime(1980, 8, 20), new List<string> { "Matemática", "Física" });
            Funcionario func1 = new Funcionario("Pedro Costa", "333.444.555-66", new DateTime(1990, 1, 15), "Secretaria");
            Aluno aluno2 = new Aluno("Mariana Lima", "444.555.666-77", new DateTime(2006, 3, 25), "A2023002", "6B");

            List<Pessoa> pessoasNaEscola = new List<Pessoa>
            {
                aluno1,
                prof1,
                func1,
                aluno2
            };

            foreach (var pessoa in pessoasNaEscola)
            {
                pessoa.Apresentar();
                Console.WriteLine(); 
            }

            Console.WriteLine("\n--- Plataforma de Cursos Online (Associações e Composição) ---");
            Curso cursoCSharp = new Curso("C# Completo");
            Curso cursoPython = new Curso("Python para Iniciantes");

            Aula aulaIntroCS = new Aula("Introdução ao C#", 60, prof1.Nome); 
            Aula aulaPOOCS = new Aula("Programação Orientada a Objetos em C#", 120, prof1.Nome);
            cursoCSharp.AdicionarAula(aulaIntroCS);
            cursoCSharp.AdicionarAula(aulaPOOCS);

            Professor prof2 = new Professor("Julia Ramos", "555.666.777-88", new DateTime(1985, 10, 5), new List<string> { "Algoritmos", "Python" });
            Aula aulaIntroPy = new Aula("Introdução ao Python", 45, prof2.Nome);
            Aula aulaEstruturasPy = new Aula("Estruturas de Dados em Python", 90, prof2.Nome);
            cursoPython.AdicionarAula(aulaIntroPy);
            cursoPython.AdicionarAula(aulaEstruturasPy);
            
            cursoCSharp.ListarAulas();
            cursoPython.ListarAulas();

            Console.WriteLine("\n--- Matrículas (Relação N:N Aluno-Curso) ---");
            List<Matricula> matriculas = new List<Matricula>();

            Matricula matricula1 = new Matricula(aluno1.Id, cursoCSharp.Id, DateTime.Now);
            matriculas.Add(matricula1);
            matricula1.AtualizarProgresso(0.25); 

            Matricula matricula2 = new Matricula(aluno2.Id, cursoCSharp.Id, DateTime.Now.AddDays(-1));
            Matricula matricula3 = new Matricula(aluno2.Id, cursoPython.Id, DateTime.Now);
            matriculas.Add(matricula2);
            matriculas.Add(matricula3);
            matricula3.AtualizarProgresso(0.10); 

            Console.WriteLine("\nLista de Matrículas Ativas:");
            foreach (var matricula in matriculas)
            {
                
                string nomeAluno = pessoasNaEscola.OfType<Aluno>().FirstOrDefault(a => a.Id == matricula.AlunoId)?.Nome ?? "Aluno não encontrado";
                string nomeCurso = (cursoCSharp.Id == matricula.CursoId ? cursoCSharp.NomeCurso : (cursoPython.Id == matricula.CursoId ? cursoPython.NomeCurso : "Curso não encontrado"));

                Console.WriteLine($"  Aluno: {nomeAluno} (ID: {matricula.AlunoId}), Curso: {nomeCurso} (ID: {matricula.CursoId}), Data Inscrição: {matricula.DataInscricao:dd/MM/yyyy}, Progresso: {matricula.Progresso:P0}");
            }
            cursoCSharp.RemoverAula("Introdução ao C#");
            cursoCSharp.ListarAulas();


            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}