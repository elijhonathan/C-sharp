using System;

class Pessoa
{
    private string nome;
    private int idade;

    public Pessoa(string n, int i)
    {
        nome = n;
        idade = i;
    }

    public string GetNome()
    {
        return nome;
    }

    public int GetIdade()
    {
        return idade;
    }
}

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira o nome e a idade da pessoa
        string nome = Console.ReadLine();

        int idade = int.Parse(Console.ReadLine());

        // Cria um objeto Pessoa com base nas informações fornecidas pelo usuário
        Pessoa pessoa = new Pessoa(nome, idade);

        // Exibe o nome e a idade usando os métodos criados
        Console.WriteLine($"Nome: {pessoa.GetNome()}, Idade: {pessoa.GetIdade()}");
    }
}
