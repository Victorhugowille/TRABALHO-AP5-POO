namespace PlataformaStreaming.Models
{
    public class Serie : Midia
    {
        public int Temporadas { get; set; }
        public int Episodios { get; set; }

        public Serie(string titulo, int duracao, string genero, int temporadas, int episodios)
            : base(titulo, duracao, genero)
        {
            Temporadas = temporadas;
            Episodios = episodios;
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Temporadas: {Temporadas}");
            Console.WriteLine($"Episódios: {Episodios}");
        }
    }
}
