using PlataformaStreaming.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("==== Plataforma de Streaming ====");
        Console.WriteLine("Qual tipo de mídia deseja cadastrar?");
        Console.WriteLine("1 - Filme");
        Console.WriteLine("2 - Série");
        Console.WriteLine("3 - Documentário");
        Console.Write("Opção: ");
        int opcao = int.Parse(Console.ReadLine()!);

        switch (opcao)
        {
            case 1:
                CadastrarFilme();
                break;
            case 2:
                CadastrarSerie();
                break;
            case 3:
                CadastrarDocumentario();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }

    static void CadastrarFilme()
    {
        Console.WriteLine("\n== Cadastro de Filme ==");
        Console.Write("Título: ");
        string titulo = Console.ReadLine()!;

        Console.Write("Duração (em minutos): ");
        int duracao = int.Parse(Console.ReadLine()!);

        Console.Write("Gênero: ");
        string genero = Console.ReadLine()!;

        Console.Write("Diretor: ");
        string diretor = Console.ReadLine()!;

        Console.Write("Ano: ");
        int ano = int.Parse(Console.ReadLine()!);

        Console.Write("Quantidade de atores no elenco: ");
        int qtdElenco = int.Parse(Console.ReadLine()!);

        List<string> elenco = new List<string>();
        for (int i = 0; i < qtdElenco; i++)
        {
            Console.Write($"Ator/Atriz {i + 1}: ");
            elenco.Add(Console.ReadLine()!);
        }

        Filme filme = new Filme(titulo, duracao, genero, diretor, ano, elenco);

        Console.WriteLine("\n== Dados do Filme Cadastrado ==");
        filme.ExibirInfo();
    }

    static void CadastrarSerie()
    {
        Console.WriteLine("\n== Cadastro de Série ==");
        Console.Write("Título: ");
        string titulo = Console.ReadLine()!;

        Console.Write("Duração por episódio (em minutos): ");
        int duracao = int.Parse(Console.ReadLine()!);

        Console.Write("Gênero: ");
        string genero = Console.ReadLine()!;

        Console.Write("Número de Temporadas: ");
        int temporadas = int.Parse(Console.ReadLine()!);

        Console.Write("Número total de Episódios: ");
        int episodios = int.Parse(Console.ReadLine()!);

        Serie serie = new Serie(titulo, duracao, genero, temporadas, episodios);

        Console.WriteLine("\n== Dados da Série Cadastrada ==");
        serie.ExibirInfo();
    }

    static void CadastrarDocumentario()
    {
        Console.WriteLine("\n== Cadastro de Documentário ==");
        Console.Write("Título: ");
        string titulo = Console.ReadLine()!;

        Console.Write("Duração (em minutos): ");
        int duracao = int.Parse(Console.ReadLine()!);

        Console.Write("Gênero: ");
        string genero = Console.ReadLine()!;

        Console.Write("Tema: ");
        string tema = Console.ReadLine()!;

        Console.Write("Narrador: ");
        string narrador = Console.ReadLine()!;

        Documentario documentario = new Documentario(titulo, duracao, genero, tema, narrador);

        Console.WriteLine("\n== Dados do Documentário Cadastrado ==");
        documentario.ExibirInfo();
    }
}
