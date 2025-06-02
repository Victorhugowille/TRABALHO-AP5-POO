using System;
using System.Collections.Generic;

namespace livro
{
    class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }

    public Livro(string titulo, string autor) 
    {
        Titulo = titulo;
        Autor = autor;
    }
}

class leitor
{
    public string Nome { get; set; }
    public leitor(string nome)
    {
        Nome = nome;
    }
}
    class LivroLeitor
    {
        public Livro Livro { get; set; } 
        public leitor Leitor { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public LivroLeitor(Livro livro, leitor leitor, DateTime dataEmprestimo)
        {
            Livro = livro;
            Leitor = leitor;
            DataEmprestimo = dataEmprestimo;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Livro livro1 = new Livro("Harry Potter", "J.K. Rowling");

            Livro livro2 = new Livro("O Senhor dos Anéis", "J.R.R. Tolkien");

            leitor leitor1 = new leitor("Joao");

            leitor leitor2 = new leitor("Maria");   

            List<LivroLeitor> emprestimos = new List<LivroLeitor>();

            LivroLeitor emprestimo1 = new LivroLeitor(livro1, leitor1, DateTime.Now);
            LivroLeitor emprestimo2 = new LivroLeitor(livro2, leitor2, DateTime.Now);

            emprestimos.Add(emprestimo1);
            emprestimos.Add(emprestimo2);

            Console.WriteLine("Registros de Livros e Leitores:");
            Console.WriteLine("---------------------------------"); 
            foreach (var emprestimo in emprestimos)
            {
                Console.WriteLine($"Leitor: {emprestimo.Leitor.Nome}");
                Console.WriteLine($"Livro: {emprestimo.Livro.Titulo} (Autor: {emprestimo.Livro.Autor})");
                Console.WriteLine($"Data do Empréstimo: {emprestimo.DataEmprestimo.ToShortDateString()}");
                Console.WriteLine("---");
            }
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}


