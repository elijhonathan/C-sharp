using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int tamanhoLista = int.Parse(Console.ReadLine());

        List<string> listaClientes = new List<string>();

        for (int i = 1; i <= tamanhoLista; i++)
        {
            // TODO: Solicite ao usuário o nome do cliente e adicione à lista
            string nomeCliente = Console.ReadLine();
            listaClientes.Add(nomeCliente);
        }

        Console.WriteLine("Lista de Contatos:");

        for (int i = 0; i < listaClientes.Count; i++)
        {
            // TODO: Exibe o número do cliente na lista e o nome do cliente
            Console.WriteLine($"{i + 1}. {listaClientes[i]}");
        }
    }
}
