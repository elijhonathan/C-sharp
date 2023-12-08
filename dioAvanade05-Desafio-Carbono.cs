using System;

class Program
{
    static void Main()
    {
        // Solicita o nome do usuário, quilômetros percorridos por dia, 
        // Horas de uso de eletrônicos por dia e o número de refeições com carne:
        string nome = Console.ReadLine();
        double quilometrosPorDia = double.Parse(Console.ReadLine());
        int horasDeEletronicos = int.Parse(Console.ReadLine());
        int refeicoesComCarne = int.Parse(Console.ReadLine());

        // Chama o método para calcular a pegada de carbono
        double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);

        // Exibe o resultado para o usuário:
        Console.WriteLine($"{nome}, sua pegada de carbono e de {pegadaDeCarbono} toneladas de CO2 por ano.");

        // Aguarda a entrada do usuário antes de encerrar o programa:
        Console.ReadLine();
    }

    // Método para calcular a pegada de carbono
    static double CalcularPegadaDeCarbono(double quilometrosPorDia, int horasDeEletronicos, int refeicoesComCarne)
    {
        // Fatores de emissão específicos para cada atividade
        double fatorTransporte = 0.2;
        double fatorEletronicos = 0.1;
        double fatorCarne = 0.5;

        // Cálculo da pegada de carbono total
        double pegadaTransporte = quilometrosPorDia * 365 * fatorTransporte;
        double pegadaEletronicos = horasDeEletronicos * fatorEletronicos;
        double pegadaCarne = refeicoesComCarne * fatorCarne;

        // Soma dos valores para obter a pegada de carbono total
        double pegadaTotal = pegadaTransporte + pegadaEletronicos + pegadaCarne;

        return pegadaTotal;
    }
}
