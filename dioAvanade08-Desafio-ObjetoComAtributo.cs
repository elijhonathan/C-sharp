using System;

class Jogador
{
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public int Idade { get; set; }
    public string Posicao { get; set; }

    public Jogador(string nome, string nacionalidade, int idade, string posicao)
    {
        Nome = nome;
        Nacionalidade = nacionalidade;
        Idade = idade;
        Posicao = posicao;
    }
}

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira as informações do jogador

        string nome = Console.ReadLine();


        string nacionalidade = Console.ReadLine();


        int idade = int.Parse(Console.ReadLine());


        string posicao = Console.ReadLine();

        // Cria um objeto Jogador com base nas informações fornecidas pelo usuário
        Jogador jogador = new Jogador(nome, nacionalidade, idade, posicao);

        // Exibe as informações do jogador criado
        Console.WriteLine("Jogador criado!");
        Console.WriteLine(jogador.Nome);
        Console.WriteLine(jogador.Nacionalidade);
        Console.WriteLine(jogador.Idade);
        Console.WriteLine($"Posição: {jogador.Posicao}");
    }
}
