class Episodio
{
    public string Titulo { get; }
    public int Duracao { get; }
    public int Ordem { get; }
    public List<string> convidados = new ();
    public string Resumo => $"{Ordem} . {Titulo} ({Duracao} min) - {string.Join(", ", convidados)}";

    public Episodio(int ordem, string titulo, int duracao)
    {
        Duracao = duracao;
        Ordem = ordem;
        Titulo = titulo;
    }

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}