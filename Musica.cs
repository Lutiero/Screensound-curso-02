class Musica
{
    public Musica(Banda artista, string nome)
    {
        Nome = nome;
        Artista = artista;
    }

    public string? Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public string? DescricaoResumida => $"\nA música '{Nome}' pertence a banda '{Artista.Nome}'.";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine("************ Ficha Técnica *******");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        string disponibilidade = (Disponivel) ? "Sim" : "Não";
        Console.WriteLine($"Disponibilidade: {disponibilidade}");
        Console.WriteLine($"Descrição resumida: {DescricaoResumida}");
    }
}