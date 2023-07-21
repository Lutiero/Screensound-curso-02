Banda queen = new Banda("Queen");
Album albumDoQueen = new Album("A night at the opera");


Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};


albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
//albumDoQueen.MostraMusicas();
//queen.ExibirDiscografia();

Podcast podcast = new ("www.podcast.com/alura", "Podcast Alura");
Episodio episodio = new (2, "Ep01", 60);
podcast.AdicionarEpisodio(episodio);
episodio.AdicionarConvidados("Lutiero");
episodio.AdicionarConvidados("Arnaldo");

Episodio episodio2 = new(1, "Ep02", 90);
podcast.AdicionarEpisodio(episodio2);
episodio2.AdicionarConvidados("Eduardo");
episodio2.AdicionarConvidados("Andreza");

podcast.ExibeDetalhes();



