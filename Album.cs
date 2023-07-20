class Album
{
    public Album(string nome)
    {
        Nome = nome;
    }

    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void MostraMusicas()
    {
        Console.WriteLine("************ Lista de músicas *******");
        musicas.ForEach(musica => 
        {
            Console.WriteLine($"{musica.Nome}");
        });
        Console.WriteLine($"\nPara ouvir esse álbum inteiro você precisa de {DuracaoTotal} segundos.");
    }


}