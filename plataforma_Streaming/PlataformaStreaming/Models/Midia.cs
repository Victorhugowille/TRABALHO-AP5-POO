namespace PlataformaStreaming.Models
{
    public class Midia
    {
        public string Titulo { get; set; }
        public int Duracao { get; set; } // Em minutos
        public string Genero { get; set; }

        public Midia(string titulo, int duracao, string genero)
        {
            Titulo = titulo;
            Duracao = duracao;
            Genero = genero;
        }

        public virtual void ExibirInfo()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Duração: {Duracao} minutos");
            Console.WriteLine($"Gênero: {Genero}");
        }
    }
}
