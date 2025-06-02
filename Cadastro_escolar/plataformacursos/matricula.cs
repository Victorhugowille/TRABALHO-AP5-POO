using System;
using Cadastro_escolar.hierarquia;

namespace Cadastro_escolar.plataformacursos
{
    public class Matricula
    {
        public int AlunoId { get; set; } 
        public int CursoId { get; set; } 
        public DateTime DataInscricao { get; set; }
        public double Progresso { get; set; } 

        public Matricula(int alunoId, int cursoId, DateTime dataInscricao)
        {
            AlunoId = alunoId;
            CursoId = cursoId;
            DataInscricao = dataInscricao;
            Progresso = 0.0;
        }

        public void AtualizarProgresso(double novoProgresso)
        {
            if (novoProgresso >= 0.0 && novoProgresso <= 1.0)
            {
                Progresso = novoProgresso;
                Console.WriteLine($"Progresso do aluno ID {AlunoId} no curso ID {CursoId} atualizado para {Progresso:P0}.");
            }
            else
            {
                Console.WriteLine("Valor de progresso inválido.");
            }
        }

        public void ExibirDetalhes()
        {
             Console.WriteLine($"  Matrícula: Aluno ID {AlunoId} no Curso ID {CursoId}, Data Inscrição: {DataInscricao:dd/MM/yyyy}, Progresso: {Progresso:P0}");
        }
    }
}