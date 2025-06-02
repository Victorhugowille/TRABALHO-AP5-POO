namespace PlataformaStreaming.Models
{
    public class Documentario : Midia
    {
        public string Tema { get; set; }
        public string Narrador { get; set; }

        public Documentario(string titulo, int duracao, string genero, string tema, string narrador)
            : base(titulo, duracao, genero)
        {
            Tema = tema;
            Narrador = narrador;
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Tema: {Tema}");
            Console.WriteLine($"Narrador: {Narrador}");
        }
    }
}
