class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a primeira data (no formato dd/mm/aaaa):");
        string data1Str = Console.ReadLine();

        Console.WriteLine("Digite a segunda data (no formato dd/mm/aaaa):");
        string data2Str = Console.ReadLine();

        if (DateTime.TryParse(data1Str, out DateTime data1) && DateTime.TryParse(data2Str, out DateTime data2))
        {
            TimeSpan diferenca = data2 - data1;
            int numeroDias = diferenca.Days;

            Console.WriteLine($"Número de dias entre as datas: {numeroDias} dias");
        }
        else
        {
            Console.WriteLine("Data(s) inválida(s). Certifique-se de usar o formato correto (dd/mm/aaaa).");
        }
    }
}
