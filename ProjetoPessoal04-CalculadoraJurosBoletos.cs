using System;

class Program
{
    static void Main()
    {
        // Solicita o dia do vencimento do boleto.
        Console.Write("Informe o dia do vencimento do boleto (dd/mm/aaaa): ");
        string inputDataVencimento = Console.ReadLine();

        // Parse a data informada pelo usuário.
        if (DateTime.TryParseExact(inputDataVencimento, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataVencimento))
        {
            // Obtém a data atual.
            DateTime dataAtual = DateTime.Now;

            // Calcula a diferença de dias entre a data atual e o dia do vencimento.
            int diasAtraso = (int)(dataAtual - new DateTime(dataAtual.Year, dataAtual.Month, dataVencimento.Day)).TotalDays;

            // Solicita o valor do boleto e a porcentagem de juros por dia.
            Console.Write("Informe o valor do boleto: R$ ");
            double valorBoleto = double.Parse(Console.ReadLine());

            Console.Write("Informe a porcentagem de juros por dia (%): ");
            double porcentagemJuros = double.Parse(Console.ReadLine());

            // Calcula o valor a ser pago com base nos dados fornecidos.
            double valorAPagar = CalcularValorAPagar(valorBoleto, porcentagemJuros, diasAtraso);

            // Exibe o resultado.
            Console.WriteLine($"Valor a ser pago: R$ {valorAPagar:F2}");
        }
        else
        {
            Console.WriteLine("Data de vencimento no formato incorreto. Use o formato dd/mm/aaaa.");
        }
    }

    static double CalcularValorAPagar(double valorBoleto, double porcentagemJuros, int diasAtraso)
    {
        // Calcula o valor com base na fórmula: Valor + (Valor * (PorcentagemJuros / 100) * DiasAtraso)
        return valorBoleto + (valorBoleto * (porcentagemJuros / 100) * diasAtraso);
    }
}
