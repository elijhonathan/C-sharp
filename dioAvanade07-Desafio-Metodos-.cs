using System;

class Robo
{
    public int VelocidadeAtual { get; private set; } = 0;
    public int VelocidadeMaxima { get; }
    public int VelocidadeMinima { get; }

    public Robo(int vmin, int vmax)
    {
        VelocidadeMinima = vmin;
        VelocidadeMaxima = vmax;
        VelocidadeAtual = vmin;
    }

    public void Acelerar()
    {
        if (VelocidadeAtual < VelocidadeMaxima)
        {
            VelocidadeAtual++;
        }
    }

    public void Desacelerar()
    {
        if (VelocidadeAtual > VelocidadeMinima)
        {
            VelocidadeAtual--;
        }
    }
}

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira a velocidade mínima e máxima do robô
        string[] velocidades = Console.ReadLine().Split();
        int vmin = int.Parse(velocidades[0]);
        int vmax = int.Parse(velocidades[1]);

        // Cria um objeto Robo com base nas velocidades fornecidas pelo usuário
        Robo robo = new Robo(vmin, vmax);

        // Solicita ao usuário que insira a sequência de comandos
        string comandos = Console.ReadLine();

        // Processa os comandos
        foreach (char comando in comandos)
        {
            if (comando == 'A')
            {
                robo.Acelerar();
            }
            else if (comando == 'D')
            {
                robo.Desacelerar();
            }
        }

        // Exibe a velocidade final do robô
        Console.WriteLine($"{robo.VelocidadeAtual}");
    }
}
