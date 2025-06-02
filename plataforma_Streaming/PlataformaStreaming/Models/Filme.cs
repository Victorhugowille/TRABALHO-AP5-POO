namespace PlataformaStreaming.Models
{
    public class Filme : Midia
    {
        public string Diretor { get; set; }
        public int Ano { get; set; }
        public List<string> Elenco { get; set; }

        public Filme(string titulo, int duracao, string genero, string diretor, int ano, List<string> elenco)
            : base(titulo, duracao, genero)
        {
            Diretor = diretor;
            Ano = ano;
            Elenco = elenco;
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Diretor: {Diretor}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine("Elenco: " + string.Join(", ", Elenco));
        }
    }
}
