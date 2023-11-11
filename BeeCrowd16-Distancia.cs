using System;

class Program
{
    static void Main(string[] args)
    {
        int distancia = int.Parse(Console.ReadLine());

        // Velocidade relativa entre os carros
        int velocidadeRelativa = 90 - 60;

        // Tempo necessário para cobrir a distância
        int tempo = (distancia * 60) / velocidadeRelativa;

        Console.WriteLine($"{tempo} minutos");
    }
}
