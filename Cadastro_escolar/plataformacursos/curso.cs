using System;
using System.Collections.Generic;
using System.Linq;

namespace Cadastro_escolar.plataformacursos
{
    public class Curso
    {
        private static int proximoIdCurso = 1;
        public int Id { get; private set; }
        public string NomeCurso { get; set; }
        public List<Aula> Aulas { get; private set; }

        public Curso(string nomeCurso)
        {
            Id = proximoIdCurso++;
            NomeCurso = nomeCurso;
            Aulas = new List<Aula>();
        }

        public void AdicionarAula(Aula aula)
        {
            if (aula != null)
            {
                Aulas.Add(aula);
                Console.WriteLine($"Aula '{aula.Titulo}' adicionada ao curso '{NomeCurso}'.");
            }
        }

        public void RemoverAula(string tituloAula)
        {
            Aula aulaParaRemover = Aulas.FirstOrDefault(a => a.Titulo.Equals(tituloAula, System.StringComparison.OrdinalIgnoreCase));
            if (aulaParaRemover != null)
            {
                Aulas.Remove(aulaParaRemover);
                Console.WriteLine($"Aula '{tituloAula}' removida do curso '{NomeCurso}'.");
            }
            else
            {
                Console.WriteLine($"Aula '{tituloAula}' não encontrada no curso '{NomeCurso}'.");
            }
        }

        public void ListarAulas()
        {
            Console.WriteLine($"\nAulas do Curso: {NomeCurso} (ID: {Id})");
            if (Aulas.Any())
            {
                foreach (var aula in Aulas)
                {
                    aula.ExibirDetalhes();
                }
            }
            else
            {
                Console.WriteLine("  Nenhuma aula cadastrada neste curso.");
            }
        }
    }
}