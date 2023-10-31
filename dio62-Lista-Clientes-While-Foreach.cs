using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<string> clientes = new List<string>();

        while (true)
        {
            string nome = Console.ReadLine();
            string email = Console.ReadLine();
            string telefone = Console.ReadLine();

            // Registra o cliente (simulação)
            string clienteInfo = $"{nome}, {email}, {telefone}";
            clientes.Add(clienteInfo);

            string continuar = Console.ReadLine();

            if (continuar.ToLower() != "s")
            {
                break; // Sai do loop se o usuário não quiser continuar
            }
        }

        // Exibe as informações de todos os clientes registrados
        foreach (var clienteInfo in clientes)
        {
            Console.WriteLine(clienteInfo);
        }
    }
}
