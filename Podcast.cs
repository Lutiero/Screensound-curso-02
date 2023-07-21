
class Podcast
{
    public string Host { get; }

    public string Nome { get; }

    public List<Episodio>? episodios = new();

    public int TotalEpisodios => episodios.Count;

    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios?.Add(episodio);
    }

    public void ExibeDetalhes()
    {
        Console.WriteLine($"Podcast nome: {Nome}");
        Console.WriteLine($"Host: {Host}");
        foreach(Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\n\nEste podcast possui um total de: {TotalEpisodios} episodios");
    }




}