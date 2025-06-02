using System;

namespace Cadastro_escolar.hierarquia
{
    public class Professor : Pessoa
    {
        public List<string> Disciplinas { get; set; }

        public Professor(string nome, string cpf, DateTime dataNascimento, List<string> disciplinas)
            : base(nome, cpf, dataNascimento)
        {
            Disciplinas = disciplinas ?? new List<string>();
        }

        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine($"  Tipo: Professor, Disciplinas: {string.Join(", ", Disciplinas)}");
        }
    }
}