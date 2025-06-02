using System;
namespace Cadastro_escolar.hierarquia
{
    public class Pessoa
    {
        private static int proximoId = 1;
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }

        protected Pessoa(string nome, string cpf, DateTime dataNascimento)
        {
            Id = proximoId++;
            Nome = nome;
            CPF = cpf;
            DataNascimento = dataNascimento;
        }

        public virtual void Apresentar()
        {
            Console.WriteLine($"ID: {Id}, Nome: {Nome}, CPF: {CPF}, Data de Nascimento: {DataNascimento:dd/MM/yyyy}");
        }
    }
}