class Genero
{
    public string Nome { get; set; }

    public Genero(string nome)
    {
        Nome = nome;
    }
}

class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero Genero { get; set; }
    public string DescricaoResumida => $"A musica {Nome} pertence à banda {Artista} no gênero {Genero.Nome}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("DIsponivel no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }

    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
    }
}